namespace IntCalculatorExample;

public class IntCalculator
{
    public int Result { get; private set; }

    public void Add(int x)
    {
        if (x > 0 && Result + x < Result)
        {
            throw new ArgumentException("Add with overflow");
        }

        Result += x;
    }
    
    
}