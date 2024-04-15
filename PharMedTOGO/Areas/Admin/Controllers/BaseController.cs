using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Areas.Admin.Controllers
{
    [Area(AdminConstant)]
    [Authorize(Roles = AdminConstant)]
    public class BaseController : Controller
    {

    }
}
