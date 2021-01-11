using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using ACADEMY.Utilities.Dtos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Course, long> _courseRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public TeacherService(UserManager<User> userManager, IMapper mapper, IHttpContextAccessor httpContextAccessor,
            IRepository<Course, long> courseRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _courseRepository = courseRepository;
        }

        public async Task<ApiResponse<UserVm>> GetInformationAsync()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return new ApiErrorResponse<UserVm>("Người dùng không tồn tại hoặc đã bị xoá", HttpStatusCode.NotFound);

            return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user));
        }

        public async Task<ApiResponse<UserVm>> UpdateInformationAsync(PutTeacherRequest request)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return new ApiErrorResponse<UserVm>("Người dùng không tồn tại hoặc đã bị xoá", HttpStatusCode.NotFound);

            user = _mapper.Map(request, user);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded) return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user));

            return new ApiErrorResponse<UserVm>(result.Errors.ToString(), HttpStatusCode.InternalServerError);
        }

        public async Task<ApiResponse<PagedResult<CourseVm>>> GetCoursesAsync(
            GetCoursesPagingRequest request)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses = await _courseRepository.FindAllAsync(e => e.TeacherId == userId,
                e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);
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
    }
}