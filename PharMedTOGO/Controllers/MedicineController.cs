using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Controllers
{
    public class MedicineController : BaseController
    {
        private readonly IMedicineService medicineService;
        private readonly ISaleService saleService;

        public MedicineController(
            IMedicineService _medicineService,
            ISaleService _saleService)
        {
            medicineService = _medicineService;
            saleService = _saleService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new MedicineFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(MedicineFormModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                if (model == null)
                {
                    return NotFound();
                }
                await medicineService.CreateAsync(model);

                return RedirectToAction(nameof(All), "Medicine");
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllMedicinesQueryModel query)
        {
            try
            {
                var allMedicines = await medicineService.AllAsync();
                await saleService.CheckSaleDates(allMedicines.Medicines);

                var model = medicineService.AllSorted(
                    query.SearchTerm,
                    query.Sorting,
                    query.CurrentPage,
                    query.MedicinesPerPage,
                    allMedicines);

                query.MedicinesCount = model.MedicinesCount;
                query.Medicines = model.Medicines;

                return View(query);
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var model = await medicineService.MedicineDetails(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var medicine = await medicineService.FindByIdAsync(id);

                if (medicine == null)
                {
                    return NotFound();
                }

                var formModel = new MedicineFormModel()
                {
                    Name = medicine.Name,
                    RequiresPrescription = medicine.RequiresPrescription,
                    Price = medicine.Price,
                    Category = medicine.Category,
                    Description = medicine.Description,
                    ImageUrl = medicine.ImageUrl
                };
                TempData.Add("medicineId", id);
                return View(formModel);
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MedicineFormModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                if (model == null)
                {
                    return NotFound();
                }
                await medicineService.EditAsync(id, model);

                return RedirectToAction(nameof(Details), new { id = id });
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var medicine = await medicineService.FindByIdAsync(id);
                if (medicine == null)
                {
                    return NotFound();
                }

                var model = new MedicineDeleteModel()
                {
                    Id = medicine.Id,
                    Name = medicine.Name,
                    ImageUrl = medicine.ImageUrl,
                    Price = medicine.Price,
                    Description = medicine.Description
                };
                TempData.Add("medicineId", id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await medicineService.DeleteAsync(id);

                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }
    }
}
