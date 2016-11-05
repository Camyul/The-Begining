using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void QuickSort(int[] a, int start, int end)
    {
        if (start >= end)
        {
            return;
        }
        int num = a[start];
        int first = start;
        int last = end;
        while (first < last)
        {
            int temp = 0;
            while (first < last && a[last] > a[first])
            {
                last--;
            }
            temp = a[first];
            a[first] = a[last];
            a[last] = temp;
            while (first < last && a[first] < num)
            {
                first++;
            }
            temp = a[last];
            a[last] = a[first];
            a[first] = temp;
        }
       
        QuickSort(a, start, first - 1);
        QuickSort(a, first + 1, end);
    }
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


}