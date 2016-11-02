using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];
        int maxSum = nums[0];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += nums[j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}