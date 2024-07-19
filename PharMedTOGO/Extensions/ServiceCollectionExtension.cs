using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Services;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.PaymentIntegrations.Stripe;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
            service.AddScoped<ISaleService, SaleService>();
            service.AddScoped<IMedicineService, MedicineService>();
            service.AddScoped<IAdminService, AdminService>();
            service.AddScoped<IPrescriptionService, PrescriptionService>();
            service.AddScoped<ICartService, CartService>();
            service.AddScoped<ITransactionService, TransactionService>();

            return service;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection service, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("MyConnection");
            service.AddDbContext<PharMedDbContext>(options =>
                options.UseSqlServer(connectionString));
            service.AddDatabaseDeveloperPageExceptionFilter();

            return service;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection service, IConfiguration config)
        {
            service.AddDefaultIdentity<Patient>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+/ ";
            })
            .AddRoles<IdentityRole<string>>()
            .AddEntityFrameworkStores<PharMedDbContext>();

            service.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = config["web:client_id"];
                googleOptions.ClientSecret = config["web:client_secret"];
            });

            return service;
        }

        public static IServiceCollection AddPaymentIntegration(this IServiceCollection service, IConfiguration config)
        {
            service.Configure<StripeSettings>(config.GetSection("StripeSettings"));

            return service;
        }
    }
}
