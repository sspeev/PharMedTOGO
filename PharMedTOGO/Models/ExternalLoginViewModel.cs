using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Models;

public class ExternalLoginViewModel
{
    [BindProperty]
    public RegisterViewModel Input { get; set; } = null!;

    public string ProviderDisplayName { get; set; } = string.Empty;

    public string ReturnUrl { get; set; } = string.Empty;

    [TempData]
    public string ErrorMessage { get; set; } = string.Empty;
}
