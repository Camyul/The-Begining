using System;
class Program
{
    static void Main()
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());
        string equals = "false";
        double diff = Math.Abs(numberOne - numberTwo);
        if (diff < 0.000001)
        {
            equals = "true";
        }
        Console.WriteLine(equals);
    }
}