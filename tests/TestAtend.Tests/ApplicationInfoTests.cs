using TestAtend.Desktop.Application;

namespace TestAtend.Tests;

public sealed class ApplicationInfoTests
{
    [Fact]
    public void Current_ShouldDescribeInitialDesktopApplication()
    {
        var info = ApplicationInfo.Current;

        Assert.Equal("TestAtend", info.Name);
        Assert.Contains("Fundacao", info.CurrentStage);
        Assert.Contains("WPF", info.Description);
        Assert.Contains("Windows", info.Description);
    }
}
