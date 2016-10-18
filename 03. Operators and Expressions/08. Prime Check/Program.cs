using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string isPrime = "true";
        for (int i = 2; i <= Math.Sqrt(Math.Abs(number)); i++)
        {
            if (number % i == 0)
            {
                isPrime = "false";
                break;
            }
        }
        if (number < 2)
        {
            isPrime = "false";
        }
        Console.WriteLine(isPrime);
    }
}