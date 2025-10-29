using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMAppV2.Pages;
using CRMAppV2.NorthwindSwagger;

namespace TestCRMAppV2
{
  [Collection("CRMAppV2")]
  public class TestCustomer_details
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbTabsModule),
        typeof(IgbGridModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbAvatarModule),
        typeof(IgbCheckboxModule),
        typeof(IgbListModule),
        typeof(IgbChipModule));
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      var componentUnderTest = ctx.RenderComponent<Customer_details>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
