using System.Collections.Generic;

namespace ACADEMY.Utilities.Dtos
{
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public PagedResult()
        {
            Content = new List<T>();
        }

        public ICollection<T> Content { get; set; }
    }
}