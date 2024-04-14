using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Services;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
            service.AddScoped<ISaleService, SaleService>();
            service.AddScoped<IMedicineService, MedicineService>();

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

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection service)
        {
            service.AddDefaultIdentity<Patient>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

            })
            .AddEntityFrameworkStores<PharMedDbContext>();

            return service;
        }
    }
}
