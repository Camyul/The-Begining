using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        int[] counts = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            counts[i] = 1;
        }
        int max = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j< i; j++)
            {
                if (numbers[j] <= numbers[i] && counts[i] <= (counts[j] + 1))
                {
                    counts[i] = counts[j] + 1;
                    if (max < counts[i])
                    {
                        max = counts[i];
                    }
                }
            }
        }
        //Console.WriteLine(string.Join(" ", counts));
        Console.WriteLine(n - max);
    }
}