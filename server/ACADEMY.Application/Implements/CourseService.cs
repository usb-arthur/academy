﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Enums.Course;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.StorageService;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using ACADEMY.Utilities.Dtos;
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

        private readonly IRepository<Category, long> _categoryRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;

        private readonly IStorageService _storageService;

        private readonly IUnitOfWork _unitOfWork;

        public CourseService(IRepository<Course, long> courseRepository, IMapper mapper, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, IStorageService storageService, IRepository<Category, long> categoryRepository)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _storageService = storageService;
            _categoryRepository = categoryRepository;
        }

        public async Task<ApiResponse<ICollection<CourseVm>>> GetByTeacherAsync()
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses = await _courseRepository.FindAllAsync(e => e.TeacherId == userId && !e.IsDeleted, e => e.Category,
                e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

            return new ApiSucceedResponse<ICollection<CourseVm>>(
                await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }

        public async Task<ApiResponse<CourseVm>> GetByIdAsync(long id)
        {
            var course = await _courseRepository.FindByIdAsync(id, e => e.Category, e => e.Teacher, e => e.Feedbacks,
                e => e.StudentCourses);

            if (course == null)
                return new ApiErrorResponse<CourseVm>($"Không tìm thấy khoá học nào với id {id}",
                    HttpStatusCode.NotFound);

            course.NumOfView += 1;
            course = await _courseRepository.UpdateAsync(course);

            await _unitOfWork.CommitAsync();

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

            course.IsDeleted = true;
            
            await _courseRepository.UpdateAsync(course);
            await _unitOfWork.CommitAsync();

            await _storageService.DeleteFileAsync("Courses", $"{id}.jpg");

            return new ApiSucceedResponse<bool>(true);
        }

        public async Task<ApiResponse<ICollection<CourseVm>>> GetAllAsync()
        {
            var courses = await _courseRepository.FindAllAsync(e => !e.IsDeleted, e => e.Category,
                e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

            return new ApiSucceedResponse<ICollection<CourseVm>>(await courses
                .ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }

        public async Task<ApiResponse<PagedResult<CourseVm>>> GetByCategoryIdPagingAsync(long categoryId, GetCoursesPagingRequest request)
        {
            var courses = await _courseRepository.FindAllAsync(e => !e.IsDeleted,e => e.Teacher, e => e.Category, e => e.Feedbacks,
                e => e.StudentCourses);

            var category = await _categoryRepository.FindByIdAsync(categoryId);

            courses = category.CategoryId != null ? courses.Where(e => e.CategoryId == categoryId) : courses.Where(e => e.Category.CategoryId == categoryId);

            if (!string.IsNullOrEmpty(request.Search))
            {
                courses = courses.Where(e =>
                    e.CourseName.Contains(request.Search) || e.BriefDescription.Contains(request.Search) ||
                    e.DetailDescription.Contains(request.Search) || e.Category.CategoryName.Contains(request.Search));
            }

            var total = await courses.CountAsync();
            if (request.Order == CourseOrder.Ascending)
            {
                courses = request.SortBy switch
                {
                    CourseSort.Name => courses.OrderBy(e => e.CourseName),
                    CourseSort.Price => courses.OrderBy(e => e.CourseFee),
                    CourseSort.Sale => courses.OrderBy(e => e.Sale),
                    CourseSort.View => courses.OrderBy(e => e.NumOfView),
                    _ => courses.OrderBy(e => e.CourseName)
                };
            }
            else
            {
                courses = request.SortBy switch
                {
                    CourseSort.Name => courses.OrderByDescending(e => e.CourseName),
                    CourseSort.Price => courses.OrderByDescending(e => e.CourseFee),
                    CourseSort.Sale => courses.OrderByDescending(e => e.Sale),
                    CourseSort.View => courses.OrderByDescending(e => e.NumOfView),
                    _ => courses.OrderByDescending(e => e.CourseName)
                };
            }

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

        public async Task<ApiResponse<PagedResult<CourseVm>>> GetPagingByTeacherAsync(GetCoursesPagingRequest request)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses = await _courseRepository.FindAllAsync(e => e.TeacherId == userId && !e.IsDeleted,
                e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);
            if (!string.IsNullOrEmpty(request.Search))
            {
                courses = courses.Where(e =>
                    e.CourseName.Contains(request.Search) || e.BriefDescription.Contains(request.Search) ||
                    e.DetailDescription.Contains(request.Search) || e.Category.CategoryName.Contains(request.Search));
            }

            var total = await courses.CountAsync();

            if (request.Order == CourseOrder.Ascending)
            {
                courses = request.SortBy switch
                {
                    CourseSort.Name => courses.OrderBy(e => e.CourseName),
                    CourseSort.Price => courses.OrderBy(e => e.CourseFee),
                    CourseSort.Sale => courses.OrderBy(e => e.Sale),
                    CourseSort.View => courses.OrderBy(e => e.NumOfView),
                    _ => courses.OrderBy(e => e.CourseName)
                };
            }
            else
            {
                courses = request.SortBy switch
                {
                    CourseSort.Name => courses.OrderByDescending(e => e.CourseName),
                    CourseSort.Price => courses.OrderByDescending(e => e.CourseFee),
                    CourseSort.Sale => courses.OrderByDescending(e => e.Sale),
                    CourseSort.View => courses.OrderByDescending(e => e.NumOfView),
                    _ => courses.OrderByDescending(e => e.CourseName)
                };
            }

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

        public async Task<ApiResponse<CourseVm>> UpdateStatusAsync(long id, PatchCourseRequest request)
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

            return new ApiSucceedResponse<CourseVm>(_mapper.Map<Course, CourseVm>(course));
        }

        public async Task<ApiResponse<ICollection<CourseVm>>> GetRelativeCourse(long categoryId, long courseId, int payload)
        {
            var courses = await _courseRepository.FindAllAsync(e=>e.CategoryId==categoryId && e.Id != courseId && !e.IsDeleted, e => e.Category,
                e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

            courses = courses.OrderByDescending(e => e.StudentCourses.Count).Take(payload);

            return new ApiSucceedResponse<ICollection<CourseVm>>(
                await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }

        public async Task<ApiResponse<PagedResult<CourseVm>>> GetPagingAsync(GetCoursesPagingRequest request)
        {
            var courses = await _courseRepository.FindAllAsync(e => !e.IsDeleted,
                e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);
            if (!string.IsNullOrEmpty(request.Search))
            {
                courses = courses.Where(e =>
                    e.CourseName.Contains(request.Search) || e.BriefDescription.Contains(request.Search) ||
                    e.DetailDescription.Contains(request.Search) || e.Category.CategoryName.Contains(request.Search));
            }

            var total = await courses.CountAsync();

            if (request.Order == CourseOrder.Ascending)
            {
                courses = request.SortBy switch
                {
                    CourseSort.Name => courses.OrderBy(e => e.CourseName),
                    CourseSort.Price => courses.OrderBy(e => e.CourseFee),
                    CourseSort.Sale => courses.OrderBy(e => e.Sale),
                    CourseSort.View => courses.OrderBy(e => e.NumOfView),
                    _ => courses.OrderBy(e => e.CourseName)
                };
            }
            else
            {
                courses = request.SortBy switch
                {
                    CourseSort.Name => courses.OrderByDescending(e => e.CourseName),
                    CourseSort.Price => courses.OrderByDescending(e => e.CourseFee),
                    CourseSort.Sale => courses.OrderByDescending(e => e.Sale),
                    CourseSort.View => courses.OrderByDescending(e => e.NumOfView),
                    _ => courses.OrderByDescending(e => e.CourseName)
                };
            }

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

        private static string GetFileName(IFormFile file, long id)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString()
                .Trim('"');
            var fileName = $"{id}{Path.GetExtension(originalFileName)}";
            return fileName;
        }
    }
}