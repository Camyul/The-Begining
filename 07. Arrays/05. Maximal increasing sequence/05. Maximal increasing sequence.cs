using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        int count = 1;
        int maxCount = 1;
        for (int i = 0; i < n - 1; i++)
        {
            if (num[i + 1] > num[i])
            {
                count++;
            }
            else
            {
                if (maxCount < count)
                {
                    maxCount = count;
                }
                count = 1;
            }
        }
        if (maxCount < count)
        {
            maxCount = count;
        }
        Console.WriteLine(maxCount);
    }
}