using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long number = Convert.ToInt64(Console.ReadLine());
        List<string> hexsymbol = new List<string>();
        long rest = 0;
        while (number > 0)
        {
            rest = number % 16;
            number /= 16;
            if (rest > 9)
            {
                switch (rest)
                {
                    case 10: hexsymbol.Add("A");break;
                    case 11: hexsymbol.Add("B");break;
                    case 12: hexsymbol.Add("C");break;
                    case 13: hexsymbol.Add("D");break;
                    case 14: hexsymbol.Add("E");break;
                    case 15: hexsymbol.Add("F"); break;
                    default:
                        break;
                }
            }
            else
            {
                hexsymbol.Add(Convert.ToString(rest));
            }
        }
        for (int i = hexsymbol.Count - 1; i >= 0; i--)
        {
            Console.Write(hexsymbol[i]);
        }
    }
}