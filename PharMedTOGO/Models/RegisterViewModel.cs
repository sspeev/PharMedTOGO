using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Core.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "LastName")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
        [Display(Name = "Identification number (EGN)")]
        public string EGN { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        = new List<AuthenticationScheme>();

        public string? ReturnUrl { get; set; }
    }
}
