using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Enums.Common;
using ACADEMY.Application.ViewModels.Catalog.Course;
using ACADEMY.Application.ViewModels.Common;

namespace ACADEMY.Application.Interfaces
{
    public interface IStatisticService
    {
        Task<ApiResponse<ICollection<CourseVm>>> GetPopularAsync(int payload, Criteria criteria);
    }
}