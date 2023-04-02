using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SaleProject.Data;
using SaleProject.Services;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// ConnectionString 
builder.Services.AddDbContext<SaleProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SaleProjectContext") ?? throw new InvalidOperationException("Connection string 'SaleProjectContext' not found.")));

// Register of services to Dependency Injection system.
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

var enUS = new CultureInfo("en-US");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(enUS),
    SupportedCultures = new List<CultureInfo> { enUS },
    SupportedUICultures = new List<CultureInfo> { enUS }
};
app.UseRequestLocalization(localizationOptions);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// New scope created from services to work with the Seed of the SeedingService method.
app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().SeedPopulateDataBase();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
