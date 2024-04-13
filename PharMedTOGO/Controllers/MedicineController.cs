using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Controllers
{
    public class MedicineController : Controller
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
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await medicineService.CreateAsync(model);

            return RedirectToAction("All", "Medicine");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllMedicinesQueryModel query)
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

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await medicineService.MedicineDetails(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var medicine = await medicineService.FindByIdAsync(id);

            if (medicine == null)
            {
                return BadRequest();
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

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int medicineId, MedicineFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await medicineService.EditAsync(medicineId, model);

            return RedirectToAction(nameof(Details), new { id = medicineId });
        }
    }
}
