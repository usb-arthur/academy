﻿using System;
using AutoMapper;

namespace ACADEMY.Application.AutoMapper
{
    public class DateTimeToStringProfile : Profile
    {
        public DateTimeToStringProfile()
        {
            CreateMap<DateTime, string>().ConvertUsing(dt => dt.ToString("yyyy-MM-dd"));
        }
    }
}