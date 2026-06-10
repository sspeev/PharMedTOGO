using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Web.Components;

public class MedicineSmallComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync() =>
        await Task.FromResult<IViewComponentResult>(View("MedicineSmall"));
    
}
