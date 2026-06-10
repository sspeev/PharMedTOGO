using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Web.Controllers;

[Authorize]
public class BaseController : Controller
{

}
