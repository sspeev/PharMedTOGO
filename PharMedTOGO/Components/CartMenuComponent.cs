using Microsoft.AspNetCore.Mvc;

namespace PharMedTOGO.Components
{
    public class CartMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("CartMenu"));
        }
    }
}
