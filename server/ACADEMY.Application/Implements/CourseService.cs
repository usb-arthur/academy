using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.StorageService;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace ACADEMY.Application.Implements
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course, long> _courseRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        private readonly IStorageService _storageService;

        public CourseService(IRepository<Course, long> courseRepository, IMapper mapper, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, IStorageService storageService)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _storageService = storageService;
        }

        public async Task<ApiResponse<ICollection<CourseVm>>> GetAllAsync()
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses = await _courseRepository.FindAllAsync(e => e.TeacherId == userId, e => e.Category,
                e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

            var result = courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider);

            return new ApiSucceedResponse<ICollection<CourseVm>>(
                await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }

        public async Task<ApiResponse<CourseVm>> GetByIdAsync(long id)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var course = await _courseRepository.FindSingleAsync(e => e.Id == id && e.TeacherId == userId,
                e => e.Category, e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

            if (course == null)
                return new ApiErrorResponse<CourseVm>($"Không tìm thấy khoá học nào với id {id}",
                    HttpStatusCode.NotFound);

            return new ApiSucceedResponse<CourseVm>(_mapper.Map<Course, CourseVm>(course));
        }

        public async Task<ApiResponse<CourseVm>> CreateAsync(PostCourseRequest request)
        {
            var course = _mapper.Map<PostCourseRequest, Course>(request);

            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));
            course.TeacherId = course.UpdatedBy = course.CreatedBy = userId;
            course = await _courseRepository.AddAsync(course);
            await _unitOfWork.CommitAsync();

            var fileName = GetFileName(request.Image, course.Id);
            
            await _storageService.SaveFileAsync(request.Image.OpenReadStream(), "Courses", fileName);
            
            return new ApiSucceedResponse<CourseVm>(_mapper.Map<Course, CourseVm>(course), HttpStatusCode.Created);
        }

        private string GetFileName(IFormFile file, long id)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString()
                .Trim('"');
            var fileName = $"{id}{Path.GetExtension(originalFileName)}";
            return fileName;
        }

        public async Task<ApiResponse<CourseVm>> UpdateAsync(long id, PutCourseRequest request)
        {
            var course = await _courseRepository.FindByIdAsync(id);
            if (course == null)
                return new ApiErrorResponse<CourseVm>($"Không tìm thấy khoá học nào với id {id}",
                    HttpStatusCode.NotFound);

            course = _mapper.Map(request, course);
            course.UpdatedDate = DateTime.Now;
            course.UpdatedBy = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));
            course = await _courseRepository.UpdateAsync(course);
            await _unitOfWork.CommitAsync();

            if (request.Image == null) return new ApiSucceedResponse<CourseVm>(_mapper.Map<Course, CourseVm>(course));
            
            await _storageService.DeleteFileAsync("Courses", $"{course.Id}.jpg");
            var fileName = GetFileName(request.Image, course.Id);
            await _storageService.SaveFileAsync(request.Image.OpenReadStream(), "Courses", fileName);

            return new ApiSucceedResponse<CourseVm>(_mapper.Map<Course, CourseVm>(course));
        }

        public async Task<ApiResponse<bool>> DeleteAsync(int id)
        {
            var course = await _courseRepository.FindByIdAsync(id);
            if (course == null)
                return new ApiErrorResponse<bool>($"Không tìm thấy khoá học nào với id {id}", HttpStatusCode.NotFound);

            await _courseRepository.RemoveAsync(course);
            await _unitOfWork.CommitAsync();

            await _storageService.DeleteFileAsync("Courses", $"{id}.jpg");
            
            return new ApiSucceedResponse<bool>(true);
        }
    }
}