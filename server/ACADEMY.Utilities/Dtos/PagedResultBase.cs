using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Utilities.Dtos
{
    public abstract class PagedResultBase
    {
        public int Page { get; set; }

        public int Total { get; set; }

        public int Limit { get; set; }

        public int NPage => (int) Math.Ceiling((double) Total / Limit);
    }
}
