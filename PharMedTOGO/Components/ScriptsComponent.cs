using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Components
{
    public class ScriptsComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("Scripts"));
        }
    }
}
