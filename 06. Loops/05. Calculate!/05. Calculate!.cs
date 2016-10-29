using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        double sum = 1;
        long factoriel = 1;
        double powX = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            powX *= x;
            sum += factoriel / powX;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}