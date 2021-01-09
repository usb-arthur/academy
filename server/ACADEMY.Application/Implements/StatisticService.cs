using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Enums.Common;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Data.EF;
using AutoMapper;
using System.Linq;
using System.Net;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class StatisticService : IStatisticService
    {
        private readonly AcademyDbContext _context;

        private readonly IMapper _mapper;

        private readonly IRepository<Course, long> _courseRepository;

        public StatisticService(AcademyDbContext context, IMapper mapper, IRepository<Course, long> courseRepository)
        {
            _context = context;
            _mapper = mapper;
            _courseRepository = courseRepository;
        }
        
        public async Task<ApiResponse<ICollection<CourseVm>>> GetPopularAsync(int payload, Criteria criteria)
        {
            IQueryable<Course> courses;
            switch (criteria)
            {
                case Criteria.Popular:
                {
                    var firstDataOfWeek = DateTime.Today.AddDays(-(DateTime.Now.DayOfWeek - DayOfWeek.Monday));
                    
                    courses =  await _courseRepository.FindAllAsync(e => e.Category,
                        e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);

                    courses = courses.OrderByDescending(e =>
                        e.Feedbacks.Count(feedback => feedback.CreatedDate > firstDataOfWeek)).Take(payload);
                    break;
                }
                case Criteria.New:
                {
                    courses =  await _courseRepository.FindAllAsync(e => e.Category,
                            e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);
                    courses = courses.OrderByDescending(e => e.CreatedDate).Take(payload);
                    break;
                }
                case Criteria.View:
                {
                    courses = await _courseRepository.FindAllAsync(e => e.Category,
                            e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);
                    courses = courses.OrderByDescending(e => e.NumOfView).Take(payload);
                    break;
                }
                case Criteria.MostSubscribe:
                {
                    var firstDataOfWeek = DateTime.Today.AddDays(-(DateTime.Now.DayOfWeek - DayOfWeek.Monday));
                    
                    courses = await _courseRepository.FindAllAsync(e => e.Category,
                            e => e.Teacher, e => e.Feedbacks, e => e.StudentCourses);
                    
                    courses = courses.OrderByDescending(e =>
                        e.StudentCourses.Count(studentCourse => studentCourse.CreatedDate > firstDataOfWeek)).Take(payload);
                    break;
                }
                default:
                {
                    return new ApiErrorResponse<ICollection<CourseVm>>("", HttpStatusCode.BadRequest);
                }
            }
            return new ApiSucceedResponse<ICollection<CourseVm>>(
                await courses.ProjectTo<CourseVm>(_mapper.ConfigurationProvider).ToListAsync());
        }
    }
}