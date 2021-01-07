using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ACADEMY.Application.Requests.System
{
    public class AuthRequest
    {
        [Required(AllowEmptyStrings = false)] public string AccessToken { get; set; }

        [JsonIgnore] public string RefreshToken { get; set; }
    }
}