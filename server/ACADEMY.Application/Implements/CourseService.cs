using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Security.Claims;
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
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course, long> _courseRepository;

        private readonly IUnitOfWork _unitOfWork;
        
        private readonly IMapper _mapper;
        
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CourseService(IRepository<Course, long> courseRepository, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ApiResult<ICollection<CourseVm>>> GetAllAsync()
        {
            var courses = await _courseRepository.FindAllAsync(e => e.Category, e => e.Teacher);
            return new ApiSucceedResult<ICollection<CourseVm>>(await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }

        public async Task<ApiResult<CourseVm>> GetByIdAsync(int id)
        {
            var course = await _courseRepository.FindByIdAsync(id, e =>  e.Category, e => e.Teacher);

            if (course == null)
            {
                return new ApiErrorResult<CourseVm>($"Không tìm thấy khoá học nào với id {id}", HttpStatusCode.NotFound);
            }

            return new ApiSucceedResult<CourseVm>(_mapper.Map<Course, CourseVm>(course));
        }

        public async Task<ApiResult<CourseVm>> CreateAsync(PostCourseRequest request)
        {
            var course = _mapper.Map<PostCourseRequest, Course>(request);

            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);
            course.TeacherId =  Guid.Parse(userId);
            
            course = await _courseRepository.AddAsync(course);
            await _unitOfWork.CommitAsync();
            return new ApiSucceedResult<CourseVm>(_mapper.Map<Course, CourseVm>(course), HttpStatusCode.Created);
        }

        public async Task<ApiResult<CourseVm>> UpdateAsync(int id, PutCourseRequest request)
        {
            var course = await _courseRepository.FindByIdAsync(id);
            if (course == null)
            {
                return new ApiErrorResult<CourseVm>($"Không tìm thấy khoá học nào với id {id}", HttpStatusCode.NotFound);
            }

            course = _mapper.Map(request, course);

            course = await _courseRepository.UpdateAsync(course);
            await _unitOfWork.CommitAsync();
            return new ApiSucceedResult<CourseVm>(_mapper.Map<Course, CourseVm>(course));
        }

        public async Task<ApiResult<bool>> DeleteAsync(int id)
        {
            var course = await _courseRepository.FindByIdAsync(id);
            if (course == null)
            {
                return new ApiErrorResult<bool>($"Không tìm thấy khoá học nào với id {id}", HttpStatusCode.NotFound);
            }

            await _courseRepository.RemoveAsync(course);
            await _unitOfWork.CommitAsync();
            return new ApiSucceedResult<bool>(true);
        }
    }
}
