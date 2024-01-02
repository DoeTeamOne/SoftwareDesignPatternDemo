using AbstructFactoryPattern.Abstruction;
using AbstructFactoryPattern.Implimentation;
using AdapterPattern.ClassAdopter.Implementation;
using AdapterPattern.ObjectADopter.Abstruction;
using AdapterPattern.ObjectADopter.Implementation;
using DemoPortal.Abstruction;
using DemoPortal.Implementation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

ConfigureServices(builder.Services);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IClientService, ClientService>();
    services.AddScoped<IShoppingCartClient, ShoppingCartClient>();
    services.AddScoped<IShippingCostsService, SpainShippingCostsService>();
    services.AddScoped<IShippingCostsService, EthShippingCostsServices>();
    services.AddScoped<IShoppingCartClient, ShoppingCartClient>();
    services.AddScoped<IDscountService, SpainDiscountService>();
    services.AddScoped<IDscountService, EthDiscountService>();
    services.AddScoped<ISoppingCartPurchaseFactory, SpainShoppingCartPurchaseFactory>();
    services.AddScoped<ISoppingCartPurchaseFactory, EthShoppingCartPurchaseFactory>();
    services.AddScoped<IGarageClientService, GarageClientService>();
    services.AddScoped<IcityAdopter, CityAdopter>();
    services.AddScoped<IcityAdopter,C_CityAdopter>();
}
