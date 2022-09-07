using IntCalculatorExample;

namespace MSTestProject;

public class UnitTest1
{
    [DataTestMethod]
    [DataRow(0, 1, 1)]
    [DataRow(0, -1, -1)]
    [DataRow(0, int.MaxValue, int.MaxValue)]
    [DataRow(int.MaxValue - 3, -3, int.MaxValue)]
    [DataRow(0, int.MinValue, int.MinValue)]
    [DataRow(int.MinValue + 3, -3, int.MinValue)]
    public void AddValidValue(int initialValue, int addValue, int exspectedValue)
    {
        //Arange
        IntCalculator cal = new IntCalculator();
        cal.Add(initialValue);
        
        //Act
        cal.Add(addValue);
        
        //Assert
        Assert.AreEqual(initialValue + addValue, cal.Result);
    }

    [TestMethod]
    public void AddInvalidValueExpectArugumentException()
    {
        //Arange
        IntCalculator cal = new IntCalculator();
        int initialValue = Int32.MaxValue;
        cal.Add(initialValue);
        
        //Act+Assert
        var ex = Assert.ThrowsException<ArgumentException>(() => cal.Add(1));
        Assert.AreEqual("Add with overflow", ex.Message);
    }
}