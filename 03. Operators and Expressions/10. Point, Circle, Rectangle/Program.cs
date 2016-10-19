using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = Math.Sqrt(((x - 1) * (x-1)) + ((y-1) * (y-1)));
        if (radius > 1.5)
        {
            Console.Write("outside circle" );
        }
        else
        {
            Console.Write("inside circle" );

        }
        if ((x >= -1 && x <= 5) && ((y >= -1) && (y <= 1)))
        {
            Console.Write(" inside rectangle");

        }
        else
        {
            Console.Write(" outside rectangle");

        }
    }
}