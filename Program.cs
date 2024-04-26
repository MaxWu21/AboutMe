using AboutMe.Infrastructure.Repositories;
using SimpleInjector;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// ASP.NET default stuff here
services.AddControllersWithViews();

services.AddLogging();
services.AddLocalization(options => options.ResourcesPath = "Resources");

// Sets up the basic configuration that for integrating Simple Injector with
// ASP.NET Core by setting the DefaultScopedLifestyle, and setting up auto
// cross wiring.
var container = new SimpleInjector.Container();
services.AddSimpleInjector(container, options =>
{
    // AddAspNetCore() wraps web requests in a Simple Injector scope and
    // allows request-scoped framework services to be resolved.
    options.AddAspNetCore()

        // Ensure activation of a specific framework type to be created by
        // Simple Injector instead of the built-in configuration system.
        // All calls are optional. You can enable what you need. For instance,
        // ViewComponents, PageModels, and TagHelpers are not needed when you
        // build a Web API.
        .AddControllerActivation()
        .AddViewComponentActivation()
        .AddPageModelActivation()
        .AddTagHelperActivation();

    // Optionally, allow application components to depend on the non-generic
    // ILogger (Microsoft.Extensions.Logging) or IStringLocalizer
    // (Microsoft.Extensions.Localization) abstractions.
    options.AddLogging();
    options.AddLocalization();
});

// Add application services. For instance:
container.Register<IMyInfoRepository, MyInfoRepository>(Lifestyle.Singleton);

var app = builder.Build();

// UseSimpleInjector() finalizes the integration process.
app.Services.UseSimpleInjector(container);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Always verify the container
container.Verify();

app.Run();