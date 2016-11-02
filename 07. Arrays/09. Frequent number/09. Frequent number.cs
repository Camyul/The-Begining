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
        int count = new int();
        int maxCount = new int();
        int frequentNum = new int();
        int maxfrequentNum = new int();
        for (int i = 0; i < n; i++)
        {
            frequentNum = nums[i];
            count = 1;
            for (int j = i +1; j < n; j++)
            {
                
                if (frequentNum == nums[j])
                {
                    count++;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
                maxfrequentNum = frequentNum;
            }
        }
        Console.WriteLine("{0} ({1} times)", maxfrequentNum, maxCount);
    }
}