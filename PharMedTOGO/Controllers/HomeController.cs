using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Extensions;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Controllers;

public class HomeController(
    IMemoryCache _memoryCache,
    ICartService _cartService) : BaseController
{
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        try
        {
            var model = _memoryCache.Get<AllCartsQueryModel>(UserCacheKeyCart);

            if (model == null)
            {
                model = await _cartService.AllCartProducts(User.Id());

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(15));

                _memoryCache.Set(UserCacheKeyCart, model, cacheOptions);
            }
            return View(model);
        }
        catch (Exception e)
        {
            return View("Error", new ErrorViewModel()
            {
                ExceptionMessage = e.Message
            });
        }
    }

    [AllowAnonymous]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(int statusCode)
    {
        if (statusCode == 400)
        {
            return View("Error400");
        }
        if (statusCode == 401)
        {
            return View("Error401");
        }
        if (statusCode == 404)
        {
            return View("Error404");
        }
        return View();
    }
}
