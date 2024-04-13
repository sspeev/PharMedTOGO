using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Controllers
{
    public class PrescriptionController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
