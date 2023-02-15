global using Xunit;
using Power;

public class UnitTest1 {
    [Fact]
    public void TestPowerRoot4() {
        double a = 4;
        double b = 2;
        
        double expected = 16;
        
        double actual = Power.Class1.power(a,b);
        
        Assert.Equal(expected, actual);
    }
}