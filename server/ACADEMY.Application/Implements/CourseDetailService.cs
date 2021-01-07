using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class CourseDetailService : ICourseDetailService
    {
        private readonly IRepository<CourseDetail, long> _courseDetailRepository;

        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        public CourseDetailService(IHttpContextAccessor httpContextAccessor, IMapper mapper, IRepository<CourseDetail, long> courseDetailRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _courseDetailRepository = courseDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<ICollection<CourseDetailVm>>> GetAllAsync(long courseId)
        {
            var courseDetails = await _courseDetailRepository.FindAllAsync(e => e.CourseId == courseId, e => e.Course);

            return new ApiSucceedResponse<ICollection<CourseDetailVm>>(await courseDetails
                .ProjectTo<CourseDetailVm>(_mapper.ConfigurationProvider).ToListAsync());
        }

        public async Task<ApiResponse<CourseDetailVm>> GetByIdAsync(long id)
        {
            var courseDetail = await _courseDetailRepository.FindByIdAsync(id, e => e.Course);

            if (courseDetail == null)
            {
                return new ApiErrorResponse<CourseDetailVm>($"Không tìm thấy video nào với id = {id}",
                    HttpStatusCode.NotFound);
            }

            return new ApiSucceedResponse<CourseDetailVm>(_mapper.Map<CourseDetail, CourseDetailVm>(courseDetail));
        }

        public async Task<ApiResponse<CourseDetailVm>> CreateAsync(PostCourseDetailRequest request)
        {
            var courseDetail = await _courseDetailRepository.FindSingleAsync(e => e.Content.Equals(request.Content));
            if (courseDetail != null)
            {
                return new ApiErrorResponse<CourseDetailVm>("Nội dung chương này đã tồn tại", HttpStatusCode.Conflict);
            }

            courseDetail = _mapper.Map<PostCourseDetailRequest, CourseDetail>(request);

            courseDetail = await _courseDetailRepository.AddAsync(courseDetail);

            await _unitOfWork.CommitAsync();

            return new ApiSucceedResponse<CourseDetailVm>(_mapper.Map<CourseDetail, CourseDetailVm>(courseDetail), HttpStatusCode.Created);
        }

        public async Task<ApiResponse<CourseDetailVm>> UpdateAsync(long id, PutCourseDetailRequest request)
        {
            var courseDetail = await _courseDetailRepository.FindByIdAsync(id);
            if (courseDetail == null)
            {
                return new ApiErrorResponse<CourseDetailVm>("Không tồn tại chương này", HttpStatusCode.NotFound);
            }

            courseDetail = _mapper.Map(request, courseDetail);

            courseDetail = await _courseDetailRepository.UpdateAsync(courseDetail);

            await _unitOfWork.CommitAsync();
            
            return new ApiSucceedResponse<CourseDetailVm>(_mapper.Map<CourseDetail, CourseDetailVm>(courseDetail));
        }

        public async Task<ApiResponse<bool>> DeleteAsync(long id)
        {
            var courseDetail = await _courseDetailRepository.FindByIdAsync(id);
            if (courseDetail == null)
            {
                return new ApiErrorResponse<bool>("Không tồn tại chương này", HttpStatusCode.NotFound);
            }

            await _courseDetailRepository.RemoveAsync(id);

            await _unitOfWork.CommitAsync();
            
            return new ApiSucceedResponse<bool>(true);
        }
    }
}