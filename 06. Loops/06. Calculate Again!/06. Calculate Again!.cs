using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
            if (i <= k)
            {
                factorielK *= i;
            }
        }
        Console.WriteLine(factorielN / factorielK);
    }
}