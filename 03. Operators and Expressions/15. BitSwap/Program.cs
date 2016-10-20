using System;
class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        uint[] bitP = new uint[k];
        uint[] bitQ = new uint[k];
        int maskP = 1;
        int maskQ = 1;
        for (int i = 0; i < k; i++)
        {
            maskP = 1 << (p + i);
            bitP[i] = (n & (uint)maskP) >> (p + i);
            maskQ = 1 << (q + i);
            bitQ[i] = (n & (uint)maskQ) >> (q + i);
        }
        for (int i = 0; i < k; i++)
        {
            if (bitP[i] > 0)
            {
                maskP = 1 << q + i;
                n |= (uint)maskP;
            }
            else
            {
                maskP = ~(1 << q + i);
                n &= (uint)maskP;
            }
            if (bitQ[i] > 0)
            {
                maskQ = 1 << p + i;
                n |= (uint)maskQ;
            }
            else
            {
                maskQ = ~(1 << p + i);
                n &= (uint)maskQ;
            }
        }
        Console.WriteLine(n);
    }
}