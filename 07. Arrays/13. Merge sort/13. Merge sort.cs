using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithm
{

    public static class MegreSorter
    {
        public static void DoMegreSort(this int[] numbers)
        {
            var sortedNumbers = MegreSort(numbers);
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }
        private static int[] MegreSort(int[] numbers)
        {
            if (numbers.Lengh <= 1)
            {
                return numbers;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);

                }
            }
            left = MegreSort(left.ToArray()).ToList();
            right = MegreSort(right.ToArray()).ToList();
            return Megre(left, right);
        }
        private static int[] Megre(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())
                {
                    MoveValueFromSoureToResult(left, result);
                }
                else
                {
                    MoveValueFromSoureToResult(right, result);
                }
            }
            while (left.Count > 0)
            {
                MoveValueFromSoureToResult(left, result);
            }
            while (right.Count > 0)
            {
                MoveValueFromSoureToResult(right, result);
            }
            return result.ToArray();
        }

        private static void MoveValueFromSoureToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
    private static void Megre()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        numbers.DoMegreSort();
        Console.WriteLine(string.Join(" ", numbers));
    }

    static void Main()
    {
        Megre();
    }
}
//    static public void DoMegre(int[] numbers, int left, int mid, int right)
//    {
//        int[] temps = new int[right - left];
//        int leftEnd = mid - 1;
//        int tempPos = left;
//        int numElement = right - left - 1;
//        while ((left <= leftEnd) && (mid <=right))
//        {
//            if (numbers[left] < numbers[mid])
//            {
//                temps[tempPos] = numbers[left];
//                tempPos++;
//                left++;
//            }
//            else
//            {
//                temps[tempPos] = numbers[mid];
//                tempPos++;
//                mid++;
//            }
//            while (left <= leftEnd)
//            {
//                temps[tempPos] = numbers[left];
//                tempPos++;
//                left++;
//            }
//            while (mid <= right)
//            {
//                temps[tempPos] = numbers[right];
//                tempPos++;
//                right++;
//            }
//            for (int i = 0; i < numElement; i++)
//            {
//                numbers[right] = temps[right];
//                right--;
//            }
//        }
//    }
//    static public void MegreSortRecursive(int[] numbers, int left, int right)
//    {
//        int mid = 0;
//        if (right > left)
//        {
//            mid = (left + right) / 2;
//            MegreSortRecursive(numbers, left, mid);
//            MegreSortRecursive(numbers, (mid + 1), right);
//            DoMegre(numbers, left, (mid + 1), right);
//        }
//    }
//    static void Main()
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] nums = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            nums[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        MegreSortRecursive(nums, 0, nums.Length - 1);
//        Console.WriteLine(string.Join(" ", nums));
//    }
//}