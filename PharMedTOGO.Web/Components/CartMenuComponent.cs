using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Web.Components;

public class CartMenuComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync() =>
        await Task.FromResult<IViewComponentResult>(View("CartMenu"));
    
}
