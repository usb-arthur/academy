using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Data.Enums;

namespace ACADEMY.Application.Requests.System
{
    public class PutUserRequest
    {
        public string Name { get; set; }

        public UserGender Gender { get; set; }

        public string Contact { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
