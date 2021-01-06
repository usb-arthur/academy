using System.Collections.Generic;

namespace ACADEMY.Application.ViewModels.Catalog.Category
{
    public class CategoryVm
    {
        public long Id { get; set; }

        public string CategoryName { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public ICollection<CategoryVm> Children { get; set; }
    }
}