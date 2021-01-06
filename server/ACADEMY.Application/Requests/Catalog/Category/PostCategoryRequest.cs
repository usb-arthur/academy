using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.Catalog.Category
{
    public class PostCategoryRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên danh mục không được bỏ trống")]
        public string CategoryName { get; set; }

        public long? CategoryId { get; set; }
    }
}