using System;


class Program
{
    static void Main()
    {
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}