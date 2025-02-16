﻿using ACADEMY.Application.Requests.Catalog.Category;
using ACADEMY.Application.Requests.Catalog.Course;
using ACADEMY.Application.Requests.Common;
using ACADEMY.Application.Requests.Student;
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
            
            CreateMap<RegisterRequest, User>()
                .ForAllMembers(options => options.UseDestinationValue());

            CreateMap<PostCourseRequest, Course>()
                .ForAllMembers(options => options.UseDestinationValue());

            CreateMap<PutCourseRequest, Course>()
                .ForAllMembers(options => options.UseDestinationValue());

            CreateMap<PatchCourseRequest, Course>()
                .ForAllMembers(options => options.UseDestinationValue());
            
            CreateMap<PostCategoryRequest, Category>()
                .ForAllMembers(options => options.UseDestinationValue());

            CreateMap<PutCategoryRequest, Category>()
                .ForAllMembers(options => options.UseDestinationValue());

            CreateMap<PostCourseDetailRequest, CourseDetail>()
                .ForAllMembers(options => options.UseDestinationValue());

            CreateMap<PutCourseDetailRequest, CourseDetail>()
                .ForAllMembers(options => options.UseDestinationValue());

            CreateMap<PostWatchListRequest, WatchList>()
                .ForAllMembers(options => options.UseDestinationValue());
            
            CreateMap<PostFeedbackRequest, Feedback>()
                .ForAllMembers(options => options.UseDestinationValue());
        }
    }
}