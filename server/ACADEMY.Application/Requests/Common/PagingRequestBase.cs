using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Application.Requests.Common
{
    public abstract class PagingRequestBase
    {
        public int Page { get; set; } = 1;

        public int Limit { get; set; } = 10;
    }
}
