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

            CreateMap<Course, CourseVm>();

            CreateMap<Category, CategoryVm>()
                .ForMember(des => des.CreatedBy, options => options.MapFrom(src => src.CreatedUser.Name))
                .ForMember(des => des.UpdatedBy, options => options.MapFrom(src => src.UpdatedUser.Name));
        }
    }
}
