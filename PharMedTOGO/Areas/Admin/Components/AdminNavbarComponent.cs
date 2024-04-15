using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Areas.Admin.Components
{
    public class AdminNavbarComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("Navbar"));
        }
    }
}
