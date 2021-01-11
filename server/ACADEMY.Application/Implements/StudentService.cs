using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.EF;
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
    public class StudentService : IStudentService
    {
        private readonly AcademyDbContext _context;

        private readonly IRepository<Course, long> _courseRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public StudentService(UserManager<User> userManager, IRepository<Course, long> courseRepository,
            IHttpContextAccessor httpContextAccessor, IMapper mapper, AcademyDbContext context, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _courseRepository = courseRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<UserVm>> GetInformationAsync()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid);

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return new ApiErrorResponse<UserVm>("Người dùng không tồn tại hoặc đã bị xoá", HttpStatusCode.NotFound);

            return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user));
        }

        public async Task<ApiResponse<PagedResult<CourseVm>>> GetRegisteredCourseAsync(
            GetCoursesPagingRequest request)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            var courses =
                await _courseRepository.FindAllAsync(e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

            courses = courses.Where(e => e.StudentCourses.Count(studentCourse => studentCourse.StudentId == userId) > 0);
            
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

        public async Task<ApiResponse<StudentCourse>> SubscribeCourseAsync(long courseId)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));
            var studentCourse = await _context.StudentCourses.AddAsync(new StudentCourse
            {
                CourseId = courseId,
                StudentId = userId
            });
            await _unitOfWork.CommitAsync();
            return new ApiSucceedResponse<StudentCourse>(studentCourse.Entity);
        }

        public async Task<ApiResponse<bool>> UnsubscribeCourseAsync(long courseId)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));
            var studentCourses =
                await _context.StudentCourses.FirstOrDefaultAsync(e => e.CourseId == courseId && e.StudentId == userId);
            if (studentCourses == null)
                return new ApiErrorResponse<bool>("Khoá học này không tồn tại hoặc bạn đã huỷ đăng ký rồi",
                    HttpStatusCode.NotFound);
            _context.StudentCourses.Remove(studentCourses);
            return new ApiSucceedResponse<bool>(true);
        }

        public async Task<bool> IsInCourseAsync(long id)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            return await _context.StudentCourses.CountAsync(e => e.CourseId == id && e.StudentId == userId) > 0;
        }
    }
}