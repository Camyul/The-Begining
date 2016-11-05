using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 2; i <= n; i++)
        {
            numbers[i - 2] = i;
        }
        int step = 2;
        int j = 0;

        while (j <= n)
        {
            for (j = 2*step; j <= n; j +=step)
            {
                if (numbers[j - 2] > 0)
                {
                    numbers[j - 2] = 0;
                }
            }
            j = step + 1;
            while (j <= n)
            {
                if (numbers[j-2] > 0)
                {
                    step = numbers[j - 2];
                    break;
                }
                j++;
            }
        }
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] > 0)
            {
                Console.WriteLine(numbers[i]);
                break;
            }
        }
       
    }
}