using System;
class Program
{
    static void Main()
    {
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("{0:F2} ", Math.PI*2*radius);
        Console.Write("{0:F2}", Math.PI*radius*radius);
    }
}