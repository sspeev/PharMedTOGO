using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Data;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
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
            service.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;

            }).AddEntityFrameworkStores<PharMedDbContext>();

            return service;
        }
    }
}
