using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
