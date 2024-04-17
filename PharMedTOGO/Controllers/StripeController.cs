using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Extensions;
using PharMedTOGO.PaymentIntegrations.Stripe;
using Stripe;
using Stripe.Checkout;

namespace PharMedTOGO.Controllers
{
    public class StripeController : Controller
    {
        private readonly StripeSettings stripeSettings;
        private readonly IAdminService adminService;
        private readonly ITransactionService transactionService;

        public StripeController(
            IOptions<StripeSettings> _stripeSettings,
            IAdminService _adminService,
            ITransactionService _transactionService)
        {
            stripeSettings = _stripeSettings.Value;
            adminService = _adminService;
            transactionService = _transactionService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCheckoutSession(AllCartsQueryModel model)
        {
            string currency = "bgn";
            string successfulUrl = "https://localhost:7136/Stripe/OrderResult";
            string cancelUrl = "https://localhost:7136/Cart/ShoppingCart";
            StripeConfiguration.ApiKey = stripeSettings.SecretKey;
            var user = await adminService.FindUserById(User.Id());

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
                            UnitAmountDecimal = Convert.ToDecimal(model.Total) * 100,
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
                CustomerEmail = user.Email
            };

            var service = new SessionService();
            var session = service.Create(options);
            TempData["sessionId"] = session.Id;

            return Redirect(session.Url);
        }

        [HttpGet]
        public async Task<IActionResult> OrderResult()
        {
            var service = new SessionService();
            var session = service.Get(TempData["sessionId"].ToString());

            if (session.PaymentStatus == "paid")
            {
                var model = new TransactionServiceModel()
                {
                    Email = session.CustomerEmail,
                    Amount = Convert.ToDecimal(session.AmountTotal) / 100,
                    SessionIntendId = session.PaymentIntentId
                };
                await transactionService.AddAsync(model);

                return View("Details", model);
            }
            return View("Fail");
        }

        [HttpGet]
        public IActionResult Details(TransactionServiceModel model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult Fail()
        {
            return View();
        }
    }
}
