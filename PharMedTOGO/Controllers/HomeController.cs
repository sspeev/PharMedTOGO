using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Core.Services;
using PharMedTOGO.Extensions;
using PharMedTOGO.Models;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Controllers
{
    public class HomeController : BaseController
    {
        private IMemoryCache memoryCache;
        private readonly ICartService cartService;

        public HomeController(IMemoryCache _memoryCache, ICartService _cartService)
        {
            memoryCache = _memoryCache;
            cartService = _cartService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = memoryCache.Get<AllCartsQueryModel>(UserCacheKey);

                if (model == null)
                {
                    model = await cartService.AllCartProducts(User.Id());

                    var cacheOptions = new MemoryCacheEntryOptions()
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(15));

                    memoryCache.Set(UserCacheKey, model, cacheOptions);
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
}
