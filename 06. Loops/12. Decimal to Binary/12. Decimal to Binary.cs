using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<int> bin = new List<int>();
        while (number > 0)
        {
            bin.Add(number % 2);
            number /= 2;
        }
        for (int i = bin.Count - 1; i >= 0; i--)
        {
            Console.Write(bin[i]);
        }
    }
}