using System;
class Program
{
    static void Main()
    {
        uint n = Convert.ToUInt32(Console.ReadLine());
        uint[] bits = new uint[6];
        for (int i = 0; i < 3; i++)
        {
            int mask = 1 << (i + 3);
            bits[i] = (n & (uint)mask) >> (i + 3);
        }
        for (int i = 3; i < 6; i++)
        {
            int mask = 1 << (i + 21);
            bits[i] = (n & (uint)mask) >> (i + 21);
        }
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        for (int i = 0; i < 3; i++)
        {
            if (bits[i] > 0)
            {
                int mask = (int)bits[i] << i + 24;
                n |= (uint)mask;
            }
            else
            {
                int mask = ~(1 << i + 24);
                n &= (uint)mask;
            }
        }
        for (int i = 3; i < 6; i++)
        {
            if (bits[i] > 0)
            {
                int mask = (int)bits[i] << i;
                n |= (uint)mask;
            }
            else
            {
                int mask = ~(1 << i);
                n &= (uint)mask;
            }
        }
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(n);
    }
}