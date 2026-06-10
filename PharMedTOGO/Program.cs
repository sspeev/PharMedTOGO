using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Extensions;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.ModelBinders;

var builder = WebApplication.CreateBuilder(args);

// Load .env file for local development configuration
builder.Configuration.AddEnvFile();

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
});
builder.Services.AddPaymentIntegration(builder.Configuration);

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

builder.Services.AddApplicationServices();
builder.Services.AddMemoryCache();

var app = builder.Build();

// Automatically apply database migrations on startup
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PharMedDbContext>();
    if (context.Database.IsRelational())
    {
        await context.Database.MigrateAsync();
    }
}

if (app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Home/Error/500");
    //app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error/500");
    app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

await app.RunAsync();
