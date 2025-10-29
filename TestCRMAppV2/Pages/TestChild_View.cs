using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMAppV2.Pages;
using CRMAppV2.NorthwindSwagger;

namespace TestCRMAppV2
{
  [Collection("CRMAppV2")]
  public class TestChild_View
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbGridModule),
        typeof(IgbGridEditDoneEventArgs),
        typeof(IgbActionStripModule),
        typeof(IgbSnackbarModule));
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      var componentUnderTest = ctx.RenderComponent<Child_View>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
