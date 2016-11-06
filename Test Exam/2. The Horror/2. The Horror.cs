using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        int sum = 0;
        int count = 0;
        string[] seq = new string[sequence.Length];
        for (int i = 0; i < sequence.Length; i++)
        {
             seq[i] = sequence.Substring(i, 1);
        }
        
        for (int i = 0; i < sequence.Length; i++)
        {
            if (i % 2 == 0)
            {
                int num;
                bool result = int.TryParse(seq[i], out num);
                if (result)
                {
                    sum += num;
                    count++;
                }
                
            }
        }
        Console.Write("{0} ", count);
        Console.WriteLine(sum);
    }
}