using Xunit;
using Power;

namespace MyPowerLibTest;

public class UnitTest1 {
    [Fact]
    public void TestPowerRoot4() {
        double a = 4;
        double b = 2;
        
        double expected = 16;
        
        double actual = Class1.power(a, b);
        
        Assert.Equal(expected, actual);
    }
}