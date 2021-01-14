using System.ComponentModel.DataAnnotations;

namespace ACADEMY.Application.Requests.System
{
    public class VerifyEmailRequest
    {
        [Required]
        public string UserId { get; set; }
        
        [Required] public string Token { get; set; }
    }
}