using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Utilities.Dtos
{
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public ICollection<T> Content { get; set; }
        
        public PagedResult()
        {
            Content = new List<T>();
        }
    }
}
