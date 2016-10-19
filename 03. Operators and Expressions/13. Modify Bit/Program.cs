using System;
class Program
{
    static void Main()
    {
        ulong n = Convert.ToUInt64(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        int v = Convert.ToInt32(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            Console.WriteLine((n & (ulong)mask));
        }
        else
        {
            ulong mask = (ulong)1 << p;
            Console.WriteLine(n | mask);
        }
    }
}