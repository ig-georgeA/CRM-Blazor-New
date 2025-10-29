using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CRMAppV2;
using CRMAppV2.CRMApp;
using CRMAppV2.NorthwindSwagger;
using CRMAppV2.Financial;
using CRMAppV2.CRMAIGeneratedData;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICRMAppService, CRMAppService>();
builder.Services.AddScoped<INorthwindSwaggerService, NorthwindSwaggerService>();
builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<ICRMAIGeneratedDataService, CRMAIGeneratedDataService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbButtonModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbListModule),
        typeof(IgbChipModule),
        typeof(IgbInputModule),
        typeof(IgbSelectModule),
        typeof(IgbGridModule),
        typeof(IgbActionStripModule),
        typeof(IgbSnackbarModule),
        typeof(IgbTabsModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbCheckboxModule),
        typeof(IgbButtonGroupModule),
        typeof(IgbToggleButtonModule),
        typeof(IgbPieChartModule)
    );
}