using IntCalculatorExample;

namespace TestProject1;

public class UnitTest1
{
    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(0, -1, -1)]
    [InlineData(0, int.MaxValue, int.MaxValue)]
    [InlineData(int.MaxValue - 3, -3, int.MaxValue)]
    [InlineData(0, int.MinValue, int.MinValue)]
    [InlineData(int.MinValue + 3, -3, int.MinValue)]
    public void AddValidValue(int initialValue, int addValue, int exspectedValue)
    {
        //Arange
        IntCalculator cal = new IntCalculator();
        cal.Add(initialValue);
        
        //Act
        cal.Add(addValue);
        
        //Assert
        Assert.Equal(initialValue + addValue, cal.Result);
    }

    [Fact]
    public void AddInvalidValueExpectArugumentException()
    {
        //Arange
        IntCalculator cal = new IntCalculator();
        int initialValue = Int32.MaxValue;
        cal.Add(initialValue);
        
        //Act+Assert
        var ex = Assert.Throws<ArgumentException>(() => cal.Add(1));
        Assert.Equal("Add with overflow", ex.Message);
    }
}