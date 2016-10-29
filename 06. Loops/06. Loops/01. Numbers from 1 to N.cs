using System;

class Program
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}