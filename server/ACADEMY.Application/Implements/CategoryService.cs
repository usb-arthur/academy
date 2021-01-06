using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.Catalog.Category;
using ACADEMY.Application.ViewModels.Catalog.Category;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Data.Entities;
using ACADEMY.Infrastructure.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category, long> _categoryRepository;

        private readonly IUnitOfWork _unitOfWork;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;
        
        public CategoryService(IRepository<Category, long> categoryRepository, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<ApiResult<ICollection<CategoryVm>>> GetAllAsync()
        {
            var categories =
                await _categoryRepository.FindAllAsync(e => e.CategoryId == null,  e => e.UpdatedUser, e => e.CreatedUser, e => e.Children);

            return new ApiSucceedResult<ICollection<CategoryVm>>(await categories
                .ProjectTo<CategoryVm>(_mapper.ConfigurationProvider).ToListAsync());
        }

        public async Task<ApiResult<CategoryVm>> GetByIdAsync(long id)
        {
            var category =
                await _categoryRepository.FindByIdAsync(id, e => e.UpdatedUser, e => e.CreatedUser, e => e.Children);
            if (category == null)
            {
                return new ApiErrorResult<CategoryVm>($"Không tìm thấy danh mục với id là {id}", HttpStatusCode.NotFound);
            }

            return new ApiSucceedResult<CategoryVm>(_mapper.Map<Category, CategoryVm>(category));
        }

        public async Task<ApiResult<CategoryVm>> CreateAsync(PostCategoryRequest request)
        {
            var category = await _categoryRepository.FindSingleAsync(e =>
                e.CategoryName.Equals(request.CategoryName) && e.CategoryId.Equals(request.CategoryId));

            if (category == null)
            {
                return new ApiErrorResult<CategoryVm>($"Danh mục {request.CategoryName} đã tồn tại",
                    HttpStatusCode.Conflict);
            }
            
            category = _mapper.Map<PostCategoryRequest, Category>(request);

            var userId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Sid));
            
            category.CreatedBy = category.UpdatedBy = userId;

            category.CategoryId = request.CategoryId;

            category = await _categoryRepository.AddAsync(category);

            await _unitOfWork.CommitAsync();
            
            return new ApiSucceedResult<CategoryVm>(_mapper.Map<Category, CategoryVm>(category), HttpStatusCode.Created);
        }

        public async Task<ApiResult<CategoryVm>> UpdateAsync(long id, PutCategoryRequest request)
        {
            var category =
                await _categoryRepository.FindByIdAsync(id, e => e.Children, e => e.CreatedUser, e => e.UpdatedUser);

            if (category == null)
            {
                return new ApiErrorResult<CategoryVm>($"Không tìm thấy danh mục với id là {id}",
                    HttpStatusCode.NotFound);
            }
            
            category = _mapper.Map(request, category);

            category = await _categoryRepository.UpdateAsync(category);

            await _unitOfWork.CommitAsync();
            
            return new ApiSucceedResult<CategoryVm>(_mapper.Map<Category, CategoryVm>(category));
        }

        public async Task<ApiResult<bool>> DeleteAsync(long id)
        {
            var category =
                await _categoryRepository.FindByIdAsync(id);

            if (category == null)
            {
                return new ApiErrorResult<bool>($"Không tìm thấy danh mục với id là {id}",
                    HttpStatusCode.NotFound);
            }

            await _categoryRepository.RemoveAsync(category);
            await _unitOfWork.CommitAsync();

            return new ApiSucceedResult<bool>(true);
        }
    }
}