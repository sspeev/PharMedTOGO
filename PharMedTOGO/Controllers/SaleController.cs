﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class SaleController : Controller
    {
        private readonly ISaleService saleService;
        private readonly IMedicineService medicineService;

        public SaleController(
            ISaleService _saleService,
            IMedicineService _medicineService)
        {
            saleService = _saleService;
            medicineService = _medicineService;
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            return View(new SaleFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(SaleFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model == null)
            {
                return BadRequest();
            }
            await saleService.CreateAsync(model);
            //await medicineService.AttachSaleToMedticine((int)TempData["medicineId"], saleModel);

            return RedirectToAction("All", "Sale");
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllSalesQueryModel query)
        {
            var model = await saleService.AllAsync();

            query.TotalSales = model.TotalSales;
            query.Sales = model.Sales;
            query.Medicines = model.Medicines;

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> AttachMedicine(int saleId)
        {
            var medicines = await medicineService.AllAsync();
            var model = new AttachMedicineFormModel()
            {
                SaleId = saleId,
                Medicines = medicines.Medicines.Where(m => m.SaleId == null).ToList(),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AttachMedicine(int saleId, int medicineId)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}
            await saleService.AttachMedicine(saleId, medicineId);

            var medicines = await medicineService.AllAsync();
            var model = new AttachMedicineFormModel()
            {
                SaleId = saleId,
                Medicines = medicines.Medicines.Where(m => m.SaleId == null).ToList(),
            };
            return View(model);
        }
    }
}
