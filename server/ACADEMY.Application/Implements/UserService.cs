using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ACADEMY.Application.Interfaces;
using ACADEMY.Application.Requests.System;
using ACADEMY.Application.ViewModels.Common;
using ACADEMY.Application.ViewModels.System;
using ACADEMY.Data.Entities;
using ACADEMY.Data.Enums;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Application.Implements
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ApiResponse<UserVm>> AddAsync(PostUserRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
                return new ApiErrorResponse<UserVm>("Email đã được dùng để đăng ký tài khoản khác",
                    HttpStatusCode.Conflict);

            user = _mapper.Map<PostUserRequest, User>(request);

            var password = GenerateRandomPassword();

            Console.WriteLine(password);

            user.CreatedDate = user.UpdatedDate = DateTime.Now;

            var email = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email);

            var currentUser = await _userManager.FindByEmailAsync(email.Value);

            user.CreatedBy = user.UpdatedBy = currentUser.Id;
            user.FirstLogin = true;
            user.UserName = request.Email;
            user.NormalizedEmail = user.NormalizedUserName = _userManager.NormalizeEmail(request.Email);

            var result = await _userManager.CreateAsync(user, password);

            if (!result.Succeeded)
                return new ApiErrorResponse<UserVm>("Thao tác tạo user không thành công",
                    HttpStatusCode.InternalServerError);

            result = await _userManager.AddToRoleAsync(user, "Teacher");

            if (result.Succeeded)
                return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user))
                    {StatusCode = HttpStatusCode.Created};

            return new ApiErrorResponse<UserVm>($"Không thể khởi tạo role cho người dùng {user.Email}",
                HttpStatusCode.InternalServerError);
        }

        public async Task<ApiResponse<bool>> DeleteAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null) return new ApiErrorResponse<bool>("User cần xoá không tồn tại", HttpStatusCode.NotFound);

            user.Status = UserStatus.Deactivated;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded) return new ApiSucceedResponse<bool>(true);

            return new ApiErrorResponse<bool>("Thao tác xoá user không thành công", HttpStatusCode.InternalServerError);
        }

        public async Task<ApiResponse<ICollection<UserVm>>> GetAllAsync()
        {
            var users = _userManager.Users.Where(e => e.Status != UserStatus.Deactivated).ProjectTo<UserVm>(_mapper.ConfigurationProvider);
            return new ApiSucceedResponse<ICollection<UserVm>>(await users.ToListAsync());
        }

        public async Task<ApiResponse<UserVm>> GetByIdAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null)
                return new ApiErrorResponse<UserVm>($"Không thể tìm thấy user với id là {id}", HttpStatusCode.NotFound);

            return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user));
        }

        public async Task<ApiResponse<UserVm>> UpdateAsync(Guid id, PutUserRequest request)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return new ApiErrorResponse<UserVm>($"Không thể tìm thấy user với id là {id}", HttpStatusCode.NotFound);

            user = _mapper.Map(request, user);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded) return new ApiSucceedResponse<UserVm>(_mapper.Map<User, UserVm>(user));

            return new ApiErrorResponse<UserVm>("Thao tác chỉnh sửa không thành công",
                HttpStatusCode.InternalServerError);
        }

        private static string GenerateRandomPassword(PasswordOptions options = null)
        {
            options ??= new PasswordOptions
            {
                RequiredLength = 8,
                RequiredUniqueChars = 4,
                RequireDigit = true,
                RequireLowercase = true,
                RequireNonAlphanumeric = true,
                RequireUppercase = true
            };

            var randomChars = new[]
            {
                "ABCDEFGHJKLMNOPQRSTUVWXYZ", // uppercase 
                "abcdefghijkmnopqrstuvwxyz", // lowercase
                "0123456789", // digits
                "!@$?_-" // non-alphanumeric
            };

            var rand = new Random(Environment.TickCount);
            var chars = new List<char>();

            if (options.RequireUppercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[0][rand.Next(0, randomChars[0].Length)]);

            if (options.RequireLowercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[1][rand.Next(0, randomChars[1].Length)]);

            if (options.RequireDigit)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[2][rand.Next(0, randomChars[2].Length)]);

            if (options.RequireNonAlphanumeric)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[3][rand.Next(0, randomChars[3].Length)]);

            for (var i = chars.Count;
                i < options.RequiredLength
                || chars.Distinct().Count() < options.RequiredUniqueChars;
                i++)
            {
                var rcs = randomChars[rand.Next(0, randomChars.Length)];
                chars.Insert(rand.Next(0, chars.Count),
                    rcs[rand.Next(0, rcs.Length)]);
            }

            return new string(chars.ToArray());
        }
    }
}