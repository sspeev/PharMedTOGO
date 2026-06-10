namespace PharMedTOGO.Web.PaymentIntegrations.Stripe;

public class StripeSettings
{
    public string SecretKey { get; set; } = null!;

    public string PublishableKey { get; set; } = null!;
}
