using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMAppV2.Shared;

namespace TestCRMAppV2
{
  [Collection("CRMAppV2")]
  public class TestMainLayout
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbNavDrawerModule));
      var componentUnderTest = ctx.RenderComponent<MainLayout>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
