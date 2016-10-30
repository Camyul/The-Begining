using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 1 + i; j <= n + i; j++)
        //    {
        //        Console.Write("{0} ", j);
        //    }
        //    Console.WriteLine();
        //}
        int step = 0;
        for (int i = 1; i <= n + step; i++)
        {
            if (i <= n +step)
            {
                Console.Write("{0} ", i);
            }
            if (i == n + step)
            {
                Console.WriteLine();
                step++;
                i = step;
            }
            if (step == n)
            {
                break;
            }
        }
    }
}