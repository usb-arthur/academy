using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Catalog.Category;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.Requests.System;
using ACADEMY.Data.Entities;
using ACADEMY.Data.Enums;
using AutoMapper;

namespace ACADEMY.Application.AutoMapper
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<PostUserRequest, User>()
                .ForMember(des => des.Status,
                    options => options.NullSubstitute(UserStatus.Active));

            CreateMap<PutUserRequest, User>()
                .ForAllMembers(options => options.UseDestinationValue());
            
            CreateMap<PostCourseRequest, Course>()
                .ForAllMembers(options => options.UseDestinationValue());
            
            CreateMap<PutCourseRequest, Course>()
                .ForAllMembers(options => options.UseDestinationValue());
            
            CreateMap<PostCategoryRequest, Category>()
                .ForAllMembers(options => options.UseDestinationValue());
            
            CreateMap<PutCategoryRequest, Category>()
                .ForAllMembers(options => options.UseDestinationValue());
        }
    }
}
