using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Common;

namespace ACADEMY.Application.Requests.System
{
    public class GetUserRequest : PagingRequestBase
    {
        public string Search { get; set; }
    }
}
