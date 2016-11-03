using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        int target = Convert.ToInt32(Console.ReadLine());
        int first = 0;
        int mid = 0;
        int last = nums.Length - 1;
        bool found = false;
        while (!found && first <= last)
        {
            mid = first + (last - first) / 2;
            if (target == nums[mid])
            {
                found = true;
                Console.WriteLine(mid);
                return;
            }
            else
            {
                if (target > nums[mid])
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }
        }
        Console.WriteLine(nums[first] >= target ? first : last);
    }
}