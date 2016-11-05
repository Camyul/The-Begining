
using System;
namespace adc
{
    public class Permu
    {
        static void permut(int k, int n, int[] nums)
        {
            int i, j, tmp;
            /* when k > n we are done and should print */
            if (k <= n)
            {
                for (i = k; i <= n; i++)
                {
                    tmp = nums[i];
                    for (j = i; j > k; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[k] = tmp;
                    /* recurse on k+1 to n */
                    permut(k + 1, n, nums);
                    for (j = k; j < i; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[i] = tmp;
                }
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", nums[i]);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int iCount;
            
            int i;
            Console.Write("Enter n: ");
            iCount = int.Parse(Console.ReadLine());
            /* create a workspace of numbers in their respective places */
            int[] rgNum = new int[iCount + 1];
            for (i = 1; i <= iCount; i++)
            {
                rgNum[i] = i;
            }
            Console.WriteLine("Permutations:\n");
            permut(1, iCount, rgNum);
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    private static void Swap(int a, int b)
//    {
//        if (a == b)
//        {
//            return;
//        }
//        else
//        {
//            a ^= b;
//            b ^= a;
//            a ^= b;

//        }
//    }
//    public static void GetPair(int[] list)
//    {
//        int x = list.Length - 1;
//        GetPair(list, 0, x);
//    }
//    private static void GetPair(int[] numbs, int left, int right)
//    {
//        if (left == right)
//        {
//            Console.WriteLine(string.Join(" ", numbs));
//        }
//        else
//        {
//            for (int i = left; i <= right; i++)
//            {
//                Swap(numbs[left], numbs[i]);
//                GetPair(numbs, left + 1, right);
//                Swap(numbs[left], numbs[i]);
//            }

//        }
//    }
//    static void Main()
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] nums = new int[n];
//        for (int i = 1; i <= n; i++)
//        {
//            nums[i - 1] = i;
//        }
//        GetPair(nums);
//    }
//}