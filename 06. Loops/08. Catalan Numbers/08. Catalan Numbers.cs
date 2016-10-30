using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger factorial2N = 1;
        BigInteger factorialN = 1;
        BigInteger factorualNplus = 1;
        for (int i = 1; i <= (2 * n); i++)
        {
            factorial2N *= i;
        }
        for (int i = 1; i <= n; i++)
        {
                factorialN *= i;
        }
        Console.WriteLine(factorial2N / (((n + 1) * factorialN) * factorialN));
    }
}