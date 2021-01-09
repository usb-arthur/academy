using System.Collections.Generic;
using System.Threading.Tasks;
using ACADEMY.Application.Requests.Student;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.Student;

namespace ACADEMY.Application.Interfaces
{
    public interface IFeedbackService
    {
        Task<ApiResponse<ICollection<FeedbackVm>>> GetAllAsync(long courseId);

        Task<ApiResponse<FeedbackVm>> WriteFeedbackAsync(PostFeedbackRequest request);

        Task<ApiResponse<FeedbackVm>> EditFeedbackAsync(long id, PutFeedbackRequest request);

        Task<ApiResponse<bool>> RemoveFeedbackAsync(long feedbackId);
    }
}