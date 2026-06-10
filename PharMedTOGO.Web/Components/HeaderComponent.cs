using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Web.Components;

public class HeaderComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync() =>
        await Task.FromResult<IViewComponentResult>(View("Header"));
    
}
