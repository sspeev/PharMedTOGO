using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        = new List<AuthenticationScheme>();
    }
}
