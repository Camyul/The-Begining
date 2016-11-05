using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<long> numbers = new List<long>();

        for (int i = 1; i <= n; i++)
        {
            if ((i % 2 != 0 || i == 2) &&
                (i % 3 != 0 || i == 3) &&
                (i % 5 != 0 || i == 5) &&
                (i % 7 != 0 || i == 7) &&
                (i % 11 != 0 || i == 11))
            {
                numbers.Add(i);
            }
            //if (i < Math.Sqrt(n))
            //{
            //    for (int j = i * i; j <= n; j += 2 * i)
            //    {
            //        numbers[j] = 0;
            //    }
            //}
        }
        //for (int i = 2; i*i < numbers.Count; i++)
        //{
        //    if (numbers[i] == i*i)
        //    {
        //        numbers[i] = 0;
        //    }
        //}
        Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine(numbers[numbers.Count - 1]);
    }
}