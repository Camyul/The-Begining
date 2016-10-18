using System;
class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = Math.Sqrt((x * x) + (y * y));
        if (radius <= 2)
        {
            Console.WriteLine("yes {0:F2}", radius);
        }
        else
        {
            Console.WriteLine("no {0:F2}", radius);
        }
    }
}