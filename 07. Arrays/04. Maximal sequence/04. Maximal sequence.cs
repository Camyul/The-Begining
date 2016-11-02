using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] num = new int[n];
        int count = 1;
        int maxCount = 1;
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        if ((n == 2) && (num[0] == num[1]))
        {
            maxCount++;
        }
        while (j < n - 1)
        {
            if (num[j + 1] == num[j])
            {
                count++;
            }
            if (num[j + 1] != num[j])
            {
                if (maxCount < count)
                {
                    maxCount = count;
                }
                count = 1;
            }
            j++;
        }
        if (maxCount < count)
        {
            maxCount = count;
        }
        Console.WriteLine(maxCount);
    }
}