using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.ViewModels.Catalog.Category;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using AutoMapper;

namespace ACADEMY.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<User, UserVm>();

            CreateMap<CourseDetail, CourseDetailVm>();
            
            CreateMap<Course, CourseVm>()
                .ForMember(des => des.Rate, options => options.MapFrom(src => src.Feedbacks.Average(e => e.Rate)))
                .ForMember(des => des.NumOfFeedback,
                    options => options.MapFrom(src => src.Feedbacks.Count))
                .ForMember(des => des.NumOfStudent,
                    options => options.MapFrom(src => src.StudentCourses.Count));

            CreateMap<Category, CategoryVm>()
                .ForMember(des => des.CreatedBy, options => options.MapFrom(src => src.CreatedUser.Name))
                .ForMember(des => des.UpdatedBy, options => options.MapFrom(src => src.UpdatedUser.Name));
        }
    }
}
