
to Put on Program cs


void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IClientService, ClientService>();
    services.AddScoped<IShoppingCartClient,ShoppingCartClient>();
    services.AddScoped<IShippingCostsService, SpainShippingCostsService>();
    services.AddScoped<IShippingCostsService,EthShippingCostsServices>();
    services.AddScoped<IShoppingCartClient, ShoppingCartClient>();
    services.AddScoped<IDscountService,SpainDiscountService>();
    services.AddScoped<IDscountService, EthDiscountService>();
    services.AddScoped<ISoppingCartPurchaseFactory, SpainShoppingCartPurchaseFactory>();
    services.AddScoped<ISoppingCartPurchaseFactory, EthShoppingCartPurchaseFactory>();
}