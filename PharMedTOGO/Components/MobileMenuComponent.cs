using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Components;

public class MobileMenuComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync() =>
        await Task.FromResult<IViewComponentResult>(View("MobileMenu"));
    
}
