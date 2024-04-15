using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Models;

namespace PharMedTOGO.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService _adminService)
        {
            adminService = _adminService;
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
                var users = await adminService.AllUsersAsync();

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
    }
}
