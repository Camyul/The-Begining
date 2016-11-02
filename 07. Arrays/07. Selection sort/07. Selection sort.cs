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
        for (int i = 0; i < n; i++)
        {
            int minIndex = i;
            for (int j = i; j < n; j++)
            {
                if (num[minIndex] > num[j])
                {
                    minIndex = j;
                }
            }
            int temp = num[minIndex];
            num[minIndex] = num[i];
            num[i] = temp;
        }
        foreach (var arr in num)
        {
            Console.WriteLine(arr);
        }
    }
}