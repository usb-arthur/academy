﻿using System.ComponentModel.DataAnnotations;
using System.Linq;
using ACADEMY.Application.ViewModels.Catalog.Category;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Student;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using ACADEMY.Data.Enums.Extensions;
using AutoMapper;

namespace ACADEMY.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<User, UserVm>()
                .ForMember(des => des.UserGender,
                    options => options.MapFrom(src => src.Gender));

            CreateMap<CourseDetail, CourseDetailVm>();

            CreateMap<WatchList, WatchListVm>();

            CreateMap<Course, CourseVm>()
                .ForMember(des => des.Status,
                    options => options.MapFrom(src => src.Status.GetAttribute<DisplayAttribute>().Name))
                .ForMember(des => des.CourseStatus,
                    options => options.MapFrom(src => src.Status))
                .ForMember(des => des.Rate, options =>
                {
                    options.Condition(src => src.Feedbacks != null && src.Feedbacks.Count > 0);
                    options.NullSubstitute(0.0);
                    options.MapFrom(src => (double?) src.Feedbacks.DefaultIfEmpty().Average(e => e.Rate));
                })
                .ForMember(des => des.NumOfFeedback,
                    options => options.Condition(src => src.Feedbacks != null && src.Feedbacks.Count > 0))
                .ForMember(des => des.NumOfFeedback,
                    options => options.MapFrom(src => (int?) src.Feedbacks.Count))
                .ForMember(des => des.NumOfStudent,
                    options => options.Condition(src => src.StudentCourses != null && src.StudentCourses.Count > 0))
                .ForMember(des => des.NumOfStudent,
                    options => options.MapFrom(src => (int?) src.StudentCourses.Count))
                .ForMember(des => des.User, options => options.MapFrom(src => src.Teacher));

            CreateMap<Category, CategoryVm>()
                .ForMember(des => des.CreatedBy, options => options.MapFrom(src => src.CreatedUser.Name))
                .ForMember(des => des.UpdatedBy, options => options.MapFrom(src => src.UpdatedUser.Name));

            CreateMap<Feedback, FeedbackVm>();
        }
    }
}