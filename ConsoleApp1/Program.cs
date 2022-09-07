using System;

namespace IntCalculatorExample
{
    public class IntCalculatorProgram
    {
    public static void Main()
    {
        IntCalculator cal = new();
        cal.Add(int.MaxValue);
        Console.WriteLine(cal.Result);
        
        cal.Add(1);
        Console.WriteLine(cal.Result);
    }
}