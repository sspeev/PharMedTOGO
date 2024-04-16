using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PharMedTOGO.Areas.Admin.Models;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Extensions;
using PharMedTOGO.Infrastrucure.Data.Enums;
using PharMedTOGO.Models;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IAdminService adminService;
        private readonly IPrescriptionService prescriptionService;
        private readonly IMemoryCache memoryCache;

        public AdminController(
            IAdminService _adminService,
            IPrescriptionService _prescriptionService,
            IMemoryCache _memoryCache)
        {
            adminService = _adminService;
            prescriptionService = _prescriptionService;
            memoryCache = _memoryCache;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            try
            {
                var users = memoryCache.Get<IEnumerable<PatientServiceModel>>(UserCacheKey);

                if (users == null)
                {
                    users = await adminService.AllUsersAsync();
                    var cacheOptions = new MemoryCacheEntryOptions()
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(15));

                    memoryCache.Set(UserCacheKey, users, cacheOptions);
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
                if (!await adminService.ExistsByIdAsync(id))
                {
                    throw new ArgumentException("Unexisting user!");
                }
                if (await adminService.ExistsAdminByUserIdAsync(id))
                {
                    throw new ArgumentException("That user is already an admin!");
                }
                await adminService.MakeAdminByIdAsync(id);

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
                var prescriptions = await prescriptionService.AllAsync();

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
                await adminService.Validate(valid, id);

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
}
