using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 1; i <= n; i++)
        {
            nums[i - 1] = i;
        }
        PrintVariant(n, k, nums);
    }

    private static void PrintVariant(int n, int k, int[] nums)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(" {0}", nums[i]);
        }
        k--;
        if (k > 0)
        {
            PrintVariant(n, k, nums);
        }
    }
}