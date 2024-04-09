using Microsoft.AspNetCore.Authorization;
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
            TempData.Add("medicineId", id);
            return View(new SaleFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(SaleFormModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}

            if (model == null)
            {
                return BadRequest();
            }
            var saleModel = await saleService.CreateAsync(model);
            await medicineService.AttachSaleToMedticine((int)TempData["medicineId"], saleModel);

            TempData.Remove("medicineId");
            return RedirectToAction("All", "Medicine");
        }
    }
}
