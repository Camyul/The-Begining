using System;

class Program
{
    static void Main()
    {
        sbyte n = sbyte.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("even {0}", n);
        }
        else
        {
            Console.WriteLine("odd {0}", n);

        }
    }
}