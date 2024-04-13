using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected IActionResult GeneralError(string message = "Unexpected error occured! Try again later or contact with an administrator!")
        {
            ViewData["Message"] = message;
            return View();
        }
        //protected virtual async Task<ActionHelper> DeleteEditHelper(string id)
        //{
        //    return await Task.Run(() => { return new ActionHelper(); });
        //}
    }
}
