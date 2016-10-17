using System;

class Program
{
    static void Main()
    {
        double wight = Convert.ToDouble(Console.ReadLine());
        double moonWight = wight * 0.17;
        Console.WriteLine("{0:F3}", moonWight);
    }
}