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
            var model = await medicineService.AllSortedAsync(
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.MedicinesPerPage);

            query.MedicinesCount = model.MedicinesCount;
            query.Medicines = model.Medicines;
            await saleService.CheckSaleDates(query.Medicines);

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await medicineService.MedicineDetails(id);

            return View(model);
        }
    }
}
