using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Extensions;
using PharMedTOGO.Models;

namespace PharMedTOGO.Controllers
{
    public class PrescriptionController : Controller
    {
        private readonly IPrescriptionService prescriptionService;
        private readonly IAdminService adminService;

        public PrescriptionController(
            IPrescriptionService _prescriptionService,
            IAdminService _adminService)
        {
            prescriptionService = _prescriptionService;
            adminService = _adminService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var prescription = await prescriptionService.FindByIdAsync(id);
                var user = await adminService.FindUserById(User.Id());
                var model = new PrescriptionServiceModel()
                {
                    Id = prescription.Id,
                    CreatedOn = prescription.CreatedOn,
                    ExpireDate = prescription.ExpireDate,
                    Description = prescription.Description,
                    PrescriptionState = prescription.PrescriptionState,
                    IsValid = prescription.IsValid,
                    PatientId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    EGN = user.EGN
                };
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
        public async Task<IActionResult> Validate(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                if (!await prescriptionService.ExistsByIdAsync(id))
                {
                    return BadRequest();
                }
                await prescriptionService.ValidatePrescriptionAsync(id);

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
    }
}
