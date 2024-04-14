﻿using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Controllers
{
    public class SaleController : BaseController
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
        public IActionResult Add()
        {
            return View(new SaleFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(SaleFormModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                //validation for admin needed

                if (model == null)
                {
                    return BadRequest();
                }
                await saleService.CreateAsync(model);

                return RedirectToAction("All", "Sale");
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllSalesQueryModel query)
        {
            try
            {
                //validation for admin needed 

                var model = await saleService.AllAsync();

                query.TotalSales = model.TotalSales;
                query.Sales = model.Sales;
                query.Medicines = model.Medicines;

                return View(query);
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> AttachMedicine(int saleId)
        {
            try
            {
                //validation for admin needed
                if (!await saleService.ExistsByIdAsync(saleId))
                {
                    return BadRequest();
                }

                var medicines = await medicineService.AllAsync();
                var model = new AttachMedicineFormModel()
                {
                    SaleId = saleId,
                    Medicines = medicines.Medicines.Where(m => m.SaleId == null).ToList(),
                };
                return View(model);
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AttachMedicine(int saleId, int medicineId)
        {
            try
            {
                if (!await saleService.ExistsByIdAsync(saleId))
                {
                    return BadRequest();
                }

                await saleService.AttachMedicine(saleId, medicineId);

                var medicines = await medicineService.AllAsync();
                var model = new AttachMedicineFormModel()
                {
                    SaleId = saleId,
                    Medicines = medicines.Medicines.Where(m => m.SaleId == null).ToList(),
                };
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
                //validation for admin needed 

                var sale = await saleService.FindByIdAsync(id);

                if (sale == null)
                {
                    return BadRequest();
                }

                var model = new SaleFormModel()
                {
                    Discount = sale.Discount,
                    StartDate = sale.StartDate,
                    EndDate = sale.EndDate
                };

                TempData.Add("saleId", id);
                return View(model);
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, SaleFormModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                await saleService.EditAsync(id, model);

                return RedirectToAction(nameof(All));
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
                var sale = await saleService.FindByIdAsync(id);

                if (sale == null)
                {
                    return NotFound();
                }

                var model = new SaleDeleteModel()
                {
                    Id = sale.Id,
                    StartDate = sale.StartDate,
                    EndDate = sale.EndDate
                };
                TempData.Add("saleId", id);

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
                await saleService.DeleteAsync(id);

                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                return View("Error", "Home");
            }
        }
    }
}
