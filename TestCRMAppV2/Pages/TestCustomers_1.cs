using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMAppV2.Pages;
using CRMAppV2.NorthwindSwagger;

namespace TestCRMAppV2
{
  [Collection("CRMAppV2")]
  public class TestCustomers_1
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbInputModule),
        typeof(IgbSelectModule),
        typeof(IgbGridModule),
        typeof(IgbRowDataEventArgs),
        typeof(IgbGridEditDoneEventArgs),
        typeof(IgbActionStripModule),
        typeof(IgbSnackbarModule));
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      var componentUnderTest = ctx.RenderComponent<Customers_1>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
