using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Controllers
{
    public class MedicineController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View(new MedicineFormModel());
        }
    }
}
