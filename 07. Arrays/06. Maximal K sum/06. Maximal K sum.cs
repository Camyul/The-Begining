using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length - 1; j++)
            {
                
                if (num[j] < num[j + 1])
                {
                    int temp = num[j + 1];
                    num[j + 1] = num[j];
                    num[j] = temp;
                }
            }
        }
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += num[i];
        }
        Console.WriteLine(sum);
    }
}