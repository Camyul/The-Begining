using System;
class Program
{
    static void Main()
    {
        ulong n = Convert.ToUInt64(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        ulong mask = (ulong)(1 << p);
        Console.WriteLine((n & mask) >> p);
    }
}