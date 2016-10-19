using System;
class Program
{
    static void Main()
    {
        uint number = Convert.ToUInt32(Console.ReadLine());
        uint mask = 1 << 3;
        Console.WriteLine((number & mask) >> 3);
    }
}