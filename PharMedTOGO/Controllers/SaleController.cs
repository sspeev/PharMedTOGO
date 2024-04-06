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

        public SaleController(ISaleService _saleService)
        {
            saleService = _saleService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new SaleFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(SaleFormModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            await saleService.CreateAsync(model);

            return RedirectToAction("Index", "Home");
        }
    }
}
