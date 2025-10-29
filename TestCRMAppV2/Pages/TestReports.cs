using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMAppV2.Pages;

namespace TestCRMAppV2
{
  [Collection("CRMAppV2")]
  public class TestReports
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<Reports>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
