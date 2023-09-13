using ConsoleApp;

namespace ConsoleApp.Test;

public class UnitTest1
{
    [Fact]
    public void Test_StringUtils_Reversed()
    {
        var stringUtils = "Hello World!";
        var reverse = stringUtils.Reversed();
        Assert.Equal("!dlroW olleH" , reverse);
    }
}