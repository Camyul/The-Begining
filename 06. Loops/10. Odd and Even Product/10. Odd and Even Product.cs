using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string sequence = Console.ReadLine();
        string[] symbols = sequence.Split(' ');
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(symbols[i]);
        }
        long sumOdd = 1;
        long sumEven = 1;
        for (int i = 0, j = 1; i < n; i +=2, j +=2)
        {
            sumOdd *= numbers[i];
            if (j < n)
            {
                sumEven *= numbers[j];
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("yes {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("no {0} {1}", sumOdd, sumEven);
        }
    }
}