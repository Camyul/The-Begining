using System;
class Program
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        if (a <=b)
        {
            Console.Write("{0} ", a);
            Console.WriteLine(b);
        }
        else
        {
            Console.Write("{0} ", b);
            Console.WriteLine(a);
        }
    }
}