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
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        QuickSort(numbers, 0, numbers.Length - 1);

        foreach (var nums in numbers)
        {
            Console.WriteLine(nums);
        }
    }

    public static void QuickSort(int[] numbs, int left, int right)
    {
        
        if (left < right)
        {
            int part = Partition(numbs, left, right);
            QuickSort(numbs, left, part - 1);
            QuickSort(numbs, part + 1, right);
        }
    }
    private static int Partition(int[] nums, int begin, int end)
    {
        int pivot = nums[end];
        int temp = 0;
        int start = begin;
        for (int i = begin; i < end; i++)
        {
            if (nums[i] <= pivot)
            {
                temp = nums[i];
                nums[i] = nums[start];
                nums[start] = temp;
                start++;
            }
        }
        nums[end] = nums[start];
        nums[start] = pivot;
        return start;
    }
}