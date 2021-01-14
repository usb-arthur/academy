using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using ACADEMY.Utilities.Dtos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class WatchListService : IWatchListService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<WatchList, long> _watchListRepository;

        private readonly IRepository<Course, long> _courseRepository;

        public WatchListService(IRepository<WatchList, long> watchListRepository, IMapper mapper,
            IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork, IRepository<Course, long> courseRepository)
        {
            _watchListRepository = watchListRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
            _courseRepository = courseRepository;
        }

        public async Task<ApiResponse<PagedResult<CourseVm>>> GetAllAsync(
            GetCoursesPagingRequest request)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses =
                await _courseRepository.FindAllAsync(e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

            courses = courses.Where(e => e.WatchLists.Count(watchList => watchList.StudentId == userId) > 0);
            
            if (!string.IsNullOrEmpty(request.Search))
            {
                courses = courses.Where(e =>
                    e.CourseName.Contains(request.Search) || e.Category.CategoryName.Contains(request.Search));
            }

            var total = await courses.CountAsync();

            courses = courses.Skip((request.Page - 1) * request.Limit)
                .Take(request.Limit);

            var result = new PagedResult<CourseVm>
            {
                Content = await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync(),
                Limit = request.Limit,
                Page = request.Page,
                Total = total
            };

            return new ApiSucceedResponse<PagedResult<CourseVm>>(result);
        }

        public async Task<ApiResponse<WatchListVm>> GetByIdAsync(long id)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var watchList = await _watchListRepository.FindSingleAsync(e => e.Id == id && e.StudentId == userId,
                e => e.Course, e => e.User);

            if (watchList == null)
                return new ApiErrorResponse<WatchListVm>("Không tìm thây khoá học yêu thích", HttpStatusCode.NotFound);

            return new ApiSucceedResponse<WatchListVm>(_mapper.Map<WatchList, WatchListVm>(watchList));
        }

        public async Task<ApiResponse<WatchListVm>> CreateNewAsync(PostWatchListRequest request)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var watchList =
                await _watchListRepository.FindSingleAsync(e =>
                    e.CourseId == request.CourseId && e.StudentId == userId);
            if (watchList != null)
                return new ApiErrorResponse<WatchListVm>("Khoá học này đã ở trong danh sách yêu thích của bạn",
                    HttpStatusCode.Conflict);

            watchList = _mapper.Map<PostWatchListRequest, WatchList>(request);

            watchList.StudentId = userId;

            watchList.CreatedBy = watchList.UpdatedBy = userId;

            watchList = await _watchListRepository.AddAsync(watchList);

            await _unitOfWork.CommitAsync();

            return new ApiSucceedResponse<WatchListVm>(_mapper.Map<WatchList, WatchListVm>(watchList));
        }

        public async Task<ApiResponse<bool>> DeleteByCourseIdAsync(long courseId)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var watchList =
                await _watchListRepository.FindSingleAsync(e => e.CourseId == courseId && e.StudentId == userId);

            if (watchList == null)
                return new ApiErrorResponse<bool>("Khoá học này hiện đang không có trong danh sách yêu thích của bạn",
                    HttpStatusCode.NotFound);

            await _watchListRepository.RemoveAsync(watchList);

            await _unitOfWork.CommitAsync();

            return new ApiSucceedResponse<bool>(true);
        }

        public async Task<ApiResponse<bool>> DeleteByIdAsync(long id)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var watchList =
                await _watchListRepository.FindSingleAsync(e => e.CourseId == id && e.StudentId == userId);

            if (watchList == null)
                return new ApiErrorResponse<bool>("Khoá học này hiện đang không có trong danh sách yêu thích của bạn",
                    HttpStatusCode.NotFound);

            await _watchListRepository.RemoveAsync(watchList);

            await _unitOfWork.CommitAsync();

            return new ApiSucceedResponse<bool>(true);
        }
    }
}