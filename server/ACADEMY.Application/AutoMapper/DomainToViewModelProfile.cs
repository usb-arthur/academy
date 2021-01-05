using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
