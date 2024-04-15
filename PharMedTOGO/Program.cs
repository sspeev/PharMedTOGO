var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity();
builder.Services.AddApplicationServices();

builder.Services.AddControllersWithViews();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
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

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(config =>
{
    config.MapControllerRoute(
        name: "areas",
        pattern: "/{area:exists}/{controller=Home}/{action=Index}/{id?}");

    config.MapControllerRoute(
        name: "default",
        pattern: "/{controller=Home}/{action=Index}/{id?}");

    config.MapDefaultControllerRoute();

    app.MapRazorPages();
});

//app.MapDefaultControllerRoute();
app.MapRazorPages();

await app.RunAsync();
