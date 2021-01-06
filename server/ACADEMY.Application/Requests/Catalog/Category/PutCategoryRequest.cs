using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.Catalog.Category
{
    public class PutCategoryRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên danh mục không được bỏ trống")]
        public string CategoryName { get; set; }
    }
}