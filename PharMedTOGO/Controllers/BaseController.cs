using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
