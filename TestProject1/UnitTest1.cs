namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void AddValidValue()
    {
        //Arange
        IntCalculator cal = new IntCalculator();
        int initialValue = 10;
        int addValue = 4;
        cal.Add(initialValue);
        
        //Act
        cal.Add(addValue);
        
        //Assert
        Assert.Equal(initialValue + addValue, cal.Result);
    }

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