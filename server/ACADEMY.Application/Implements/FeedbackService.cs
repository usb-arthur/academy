using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Student;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.Student;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository<Feedback, long> _feedbackRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        private readonly UserManager<User> _userManager;

        public FeedbackService(IRepository<Feedback, long> feedbackRepository, IMapper mapper, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            _feedbackRepository = feedbackRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<ApiResponse<ICollection<FeedbackVm>>> GetAllAsync(long courseId)
        {
            var feedbacks = await _feedbackRepository.FindAllAsync(e => e.CourseId == courseId, e => e.StudentCourse);

            var result = await feedbacks.ProjectTo<FeedbackVm>(_mapper.ConfigurationProvider).ToListAsync();

            foreach (var feedback in result)
            {
                var user = await _userManager.FindByIdAsync(feedback.StudentId.ToString());
                feedback.Student = _mapper.Map<User, UserVm>(user);
            }

            return new ApiSucceedResponse<ICollection<FeedbackVm>>(
                result
            );
        }

        public async Task<ApiResponse<FeedbackVm>> WriteFeedbackAsync(PostFeedbackRequest request)
        {
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));
            var feedback = _mapper.Map<Feedback>(request);
            feedback.StudentId = feedback.CreatedBy = feedback.UpdatedBy = userId;
            feedback = await _feedbackRepository.AddAsync(feedback);
            await _unitOfWork.CommitAsync();
            return new ApiSucceedResponse<FeedbackVm>(_mapper.Map<FeedbackVm>(feedback), HttpStatusCode.Created);
        }

        public async Task<ApiResponse<FeedbackVm>> EditFeedbackAsync(long id, PutFeedbackRequest request)
        {
            var feedback = await _feedbackRepository.FindByIdAsync(id);
            if (feedback == null)
                return new ApiErrorResponse<FeedbackVm>("Comment này không tồn tại hoặc đã bị gỡ bỏ",
                    HttpStatusCode.NotFound);
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            if (feedback.StudentId != userId)
                return new ApiErrorResponse<FeedbackVm>("Bạn không có quyền sửa comment này",
                    HttpStatusCode.BadRequest);

            feedback = _mapper.Map(request, feedback);

            feedback.UpdatedDate = DateTime.Now;
            feedback = await _feedbackRepository.UpdateAsync(feedback);
            await _unitOfWork.CommitAsync();
            return new ApiSucceedResponse<FeedbackVm>(_mapper.Map<FeedbackVm>(feedback));
        }

        public async Task<ApiResponse<bool>> RemoveFeedbackAsync(long feedbackId)
        {
            var feedback = await _feedbackRepository.FindByIdAsync(feedbackId);
            if (feedback == null)
                return new ApiErrorResponse<bool>("Comment này không tồn tại hoặc đã bị gỡ bỏ",
                    HttpStatusCode.NotFound);
            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));

            if (feedback.StudentId != userId)
                return new ApiErrorResponse<bool>("Bạn không có quyền sửa comment này",
                    HttpStatusCode.BadRequest);

            await _feedbackRepository.RemoveAsync(feedback);
            await _unitOfWork.CommitAsync();

            return new ApiSucceedResponse<bool>(true);
        }
    }
}