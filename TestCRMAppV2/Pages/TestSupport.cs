using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMAppV2.Pages;
using CRMAppV2.Financial;
using CRMAppV2.CRMAIGeneratedData;

namespace TestCRMAppV2
{
  [Collection("CRMAppV2")]
  public class TestSupport
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbPieChartModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbGridModule));
      ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
      ctx.Services.AddScoped<ICRMAIGeneratedDataService>(sp => new MockCRMAIGeneratedDataService());
      var componentUnderTest = ctx.RenderComponent<Support>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
