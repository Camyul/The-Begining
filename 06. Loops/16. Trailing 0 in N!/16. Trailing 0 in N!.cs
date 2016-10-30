using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int zeros = 0;
        int i = 1;
        while (num >= (int)Math.Pow(5, i))
        {
            zeros += num / (int)Math.Pow(5, i);
            i++;
        }
        Console.WriteLine(zeros);
    }
}