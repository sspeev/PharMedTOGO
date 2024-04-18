using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Components
{
    public class MedicineSmallComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("MedicineSmall"));
        }
    }
}
