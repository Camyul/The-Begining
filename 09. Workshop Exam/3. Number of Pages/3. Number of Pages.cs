using System;
class Program
{
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        int pages = 0;
        for (int i = 0; i < digit; i++)
        {


            if (pages < 100 && pages >= 10 )
            {
               i++;
                pages++;
            }
            else if (pages < 1000 && pages >= 100)
            {
                pages++;
                i += 2;
            }
            else if (pages < 10000 && pages >= 1000)
            {
                i += 3;
                pages++;
            }
            else if (pages < 100000 && pages >= 10000)
            {
                pages++;
                i += 4;
            }
            else if (pages < 1000000 && pages >= 100000)
            {
                i += 5;
                pages++;

            }
            else 
            {
                pages++;
            }
        }
        if (pages > 10)
        {
            Console.WriteLine(pages - 1);
        }
        else
        {
            Console.WriteLine(pages);
        }
    }
}