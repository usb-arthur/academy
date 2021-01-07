using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class StudentService : IStudentService
    {
        private readonly UserManager<User> _userManager;

        private readonly IRepository<Course, long> _courseRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;

        public StudentService(UserManager<User> userManager, IRepository<Course, long> courseRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _userManager = userManager;
            _courseRepository = courseRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        
        public async Task<ApiResponse<UserVm>> GetInformationAsync()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return new ApiErrorResponse<UserVm>("Người dùng không tồn tại hoặc đã bị xoá", HttpStatusCode.NotFound);

            return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user));
        }

        public async Task<ApiResponse<ICollection<CourseVm>>> GetRegisteredCourseAsync()
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses =
                await _courseRepository.FindAllAsync(e => e.TeacherId == userId, e => e.Category, e => e.Teacher);

            return new ApiSucceedResponse<ICollection<CourseVm>>(
                await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }
    }
}