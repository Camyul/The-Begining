using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double[] numbers = new double[n];
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("min={0:F2}", numbers.Min());
        Console.WriteLine("max={0:F2}", numbers.Max());
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", sum/n);

    }
}