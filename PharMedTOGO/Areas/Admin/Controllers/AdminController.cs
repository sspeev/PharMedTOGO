using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data.Enums;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Areas.Admin.Controllers;

public class AdminController(
    IAdminService _adminService,
    IPrescriptionService _prescriptionService,
    IMemoryCache _memoryCache) : BaseController
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> AllUsers()
    {
        try
        {
            var users = _memoryCache.Get<IEnumerable<PatientServiceModel>>(UserCacheKeyAllUsers);

            if (users == null)
            {
                users = await _adminService.AllUsersAsync();
                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(15));

                _memoryCache.Set(UserCacheKeyAllUsers, users, cacheOptions);
            }

            return View(users);
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
    public async Task<IActionResult> MakeUserAdmin(string id)
    {
        try
        {
            if (!await _adminService.ExistsByIdAsync(id))
            {
                throw new ArgumentException("Unexisting user!");
            }
            if (await _adminService.ExistsAdminByUserIdAsync(id))
            {
                throw new ArgumentException("That user is already an admin!");
            }
            await _adminService.MakeAdminByIdAsync(id);
            _memoryCache.Remove(UserCacheKeyCart);

            return RedirectToAction("Index", "Admin", new { area = "Admin" });
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
    public async Task<IActionResult> ValidatePrescriptions()
    {
        try
        {
            var prescriptions = await _prescriptionService.AllAsync();

            return View(prescriptions.Where(pr => pr.PrescriptionState == PrescriptionState.Reviewing));
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
    public async Task<IActionResult> ValidatePrescriptions(bool valid, int id)
    {
        try
        {
            await _adminService.Validate(valid, id);

            return RedirectToAction("Index", "Admin", new { area = "Admin" });
        }
        catch (Exception e)
        {
            return View("Error", new ErrorViewModel()
            {
                ExceptionMessage = e.Message
            });
        }
    }
}
