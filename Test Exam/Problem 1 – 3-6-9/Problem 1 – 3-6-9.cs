using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int r = 0;
        if (b == 3)
        {
            r = a + c;
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 3);
                Console.WriteLine(r);
            }
        }
        else if (b == 6)
        {
            r = a * c;
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 3);
                Console.WriteLine(r);
            }
        }
        else //if (b == 9)
        {
            r = a % c;
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 3);
                Console.WriteLine(r);
            }
        }
    }
}