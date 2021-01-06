using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.System;
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
    public class TeacherService : ITeacherService
    {
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IRepository<Course, long> _courseRepository;

        public TeacherService(UserManager<User> userManager, IMapper mapper, IHttpContextAccessor httpContextAccessor, IRepository<Course, long> courseRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _courseRepository = courseRepository;
        }
        
        public async Task<ApiResult<UserVm>> GetInformationAsync()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return new ApiErrorResult<UserVm>("Người dùng không tồn tại hoặc đã bị xoá", HttpStatusCode.NotFound);
            }

            return new ApiSucceedResult<UserVm>(_mapper.Map<User, UserVm>(user));
        }

        public async Task<ApiResult<UserVm>> UpdateInformationAsync(PutTeacherRequest request)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);

            var user = await _userManager.FindByIdAsync(userId);
            
            if (user == null)
            {
                return new ApiErrorResult<UserVm>("Người dùng không tồn tại hoặc đã bị xoá", HttpStatusCode.NotFound);
            }

            user = _mapper.Map(request, user);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return new ApiSucceedResult<UserVm>(_mapper.Map<User, UserVm>(user));
            }

            return new ApiErrorResult<UserVm>(result.Errors.ToString(), HttpStatusCode.InternalServerError);
        }

        public async Task<ApiResult<ICollection<CourseVm>>> GetCoursesAsync()
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses = await _courseRepository.FindAllAsync(e => e.TeacherId == userId);

            return new ApiSucceedResult<ICollection<CourseVm>>(await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }
    }
}