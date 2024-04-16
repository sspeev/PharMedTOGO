using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PharMedTOGO.Core.Models;
using PharMedTOGO.PaymentIntegrations.Stripe;
using Stripe;
using Stripe.Checkout;

namespace PharMedTOGO.Controllers
{
    public class StripeController : Controller
    {
        private readonly StripeSettings stripeSettings;

        public StripeController(IOptions<StripeSettings> _stripeSettings)
        {
            stripeSettings = _stripeSettings.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCheckoutSession(AllCartsQueryModel model)
        {
            string currency = "bgn";
            string successfulUrl = "https://localhost:7136/Cart/Details";
            string cancelUrl = "https://localhost:7136/Cart/ShoppingCart";
            StripeConfiguration.ApiKey = stripeSettings.SecretKey;

            var options = new SessionCreateOptions()
            {
                PaymentMethodTypes = new List<string>()
                {
                    "card"
                },
                LineItems = new List<SessionLineItemOptions>()
                {
                    new SessionLineItemOptions()
                    {
                        PriceData = new SessionLineItemPriceDataOptions()
                        {
                            Currency = currency,
                            UnitAmountDecimal = Convert.ToInt32(model.Total) * 100,
                            ProductData = new SessionLineItemPriceDataProductDataOptions()
                            {
                                Name = "PharMedTOGO Total checkout"
                            }
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = successfulUrl,
                CancelUrl = cancelUrl,
            };

            var service = new SessionService();
            var session = service.Create(options);

            return Redirect(session.Url);
        }
    }
}
