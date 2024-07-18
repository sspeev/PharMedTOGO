using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Caching.Memory;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Models;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Controllers
{
    public class PatientController : Controller
    {
        private readonly SignInManager<Patient> signInManager;
        private readonly UserManager<Patient> userManager;
        private readonly IMemoryCache memoryCache;

        public PatientController(
            SignInManager<Patient> _signInManager,
            UserManager<Patient> _userManager,
            IMemoryCache _memoryCache
            )
        {
            userManager = _userManager;
            signInManager = _signInManager;
            memoryCache = _memoryCache;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            try
            {
                if (User?.Identity?.IsAuthenticated ?? false)
                {
                    return RedirectToAction("Index", "Home");
                }

                var model = new RegisterViewModel();
                model.ReturnUrl ??= Url.Content("~/");
                model.ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

                return View(model);
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel()
                {
                    ExceptionMessage = e.Message
                });
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var passwordHasher = new PasswordHasher<Patient>();
                var user = new Patient()
                {
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EGN = model.EGN,
                    UserName = $"{model.FirstName}{model.LastName}"
                };
                user.PasswordHash = passwordHasher.HashPassword(user, model.Password);

                var result = await userManager.CreateAsync(user, model.Password);
                await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    memoryCache.Remove(UserCacheKeyCart);
                    return RedirectToAction("Login", "Patient");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }

                return View(model);
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel()
                {
                    ExceptionMessage = e.Message
                });
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            try
            {
                if (User?.Identity?.IsAuthenticated ?? false)
                {
                    return RedirectToAction("Index", "Home");
                }

                var model = new LoginViewModel();
                model.ReturnUrl ??= Url.Content("~/");
                model.ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

                return View(model);
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel()
                {
                    ExceptionMessage = e.Message
                });
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        if (await userManager.IsInRoleAsync(user, "Admin"))
                        {
                            return RedirectToAction("Index", "Admin", new { area = "Admin" });
                        }
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid login");

                return View(model);
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel()
                {
                    ExceptionMessage = e.Message
                });
            }
        }

        public async Task<IActionResult> Logout()
        {
            try
            {
                await signInManager.SignOutAsync();

                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel()
                {
                    ExceptionMessage = e.Message
                });
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string? returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            // Request a redirect to the external login provider.
            var redirectUrl = Url.Action("ExternalLoginCallback", "Patient", new { returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            
            return new ChallengeResult(provider, properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (remoteError != null)
            {
                TempData["ErrorMessage"] = $"Error from external provider: {remoteError}";

                return RedirectToAction("Login", new { ReturnUrl = returnUrl });
            }
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                TempData["ErrorMessage"] = "Error loading external login information.";
                return RedirectToAction("Login", new { ReturnUrl = returnUrl });
            }

            // Sign in the user with this external login provider if the user already has a login.
            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            if (result.IsLockedOut)
            {
                return RedirectToPage("./Lockout");
            }
            else
            {
                var model = new ExternalLoginViewModel();
                // If the user does not have an account, then ask the user to create an account.
                model.ReturnUrl = returnUrl;
                model.ProviderDisplayName = info.ProviderDisplayName;
                if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
                {
                    string[] patientNames = info.Principal.FindFirstValue(ClaimTypes.Name).Split(" ").ToArray();
                    model.Input = new RegisterViewModel()
                    {
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                        FirstName = patientNames[0],
                        LastName = patientNames[1]
                    };
                }

                return View("ExternalLoginConfirm", model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> OnConfirmationAsync(string returnUrl = null)
        {
            var model = new ExternalLoginViewModel();
            returnUrl = returnUrl ?? Url.Content("~/");
            // Get the information about the user from the external login provider
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                model.ErrorMessage = "Error loading external login information during confirmation.";
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }

            if (ModelState.IsValid)
            {
                var user = CreateUser();

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        //var userId = await userManager.GetUserIdAsync(user);
                        //var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        //var callbackUrl = Url.Page(
                        //    "/Account/ConfirmEmail",
                        //    pageHandler: null,
                        //    values: new { area = "Identity", userId = userId, code = code },
                        //    protocol: Request.Scheme);

                        //await emailSender.SendEmailAsync(model.Input.Email, "Confirm your email",
                        //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        //// If account confirmation is required, we need to show the link if we don't have a real email sender
                        //if (userManager.Options.SignIn.RequireConfirmedAccount)
                        //{
                        //    return RedirectToPage("./RegisterConfirmation", new { Email = Input.Email });
                        //}

                        await signInManager.SignInAsync(user, isPersistent: false, info.LoginProvider);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            model.ProviderDisplayName = info.ProviderDisplayName;
            model.ReturnUrl = returnUrl;

            return RedirectToAction("Index", "Home");
        }

        private Patient CreateUser()
        {
            try
            {
                return Activator.CreateInstance<Patient>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Patient)}'. " +
                    $"Ensure that '{nameof(Patient)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the external login page in /Areas/Identity/Pages/Account/ExternalLogin.cshtml");
            }
        }
    }
}
