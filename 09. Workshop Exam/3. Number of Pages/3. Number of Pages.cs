using System;
class Program
{
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        int pages = 0;
        for (int i = 1; i <= digit; i++)
        {
            
            if (i < 100 && i >= 10 )
            {
                digit +=2;
                pages++;
            }
            else if (i < 1000 && i >= 100)
            {
                pages++;
                digit += 3;
            }
            else if (i < 10000 && i >= 1000)
            {
                digit += 4;
                pages++;
            }
            else if (i < 100000 && i >= 10000)
            {
                pages++;
                digit += 5;
            }
            else if (i < 1000000 && i >= 100000)
            {
                digit += 6;
                pages++;

            }
            else 
            {
                digit++;
                pages++;
            }
        }
        Console.WriteLine(pages);
    }
}