using System;
class Program
{
    static void Main(string[] arg)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        long firstNum = 0;
        long secondNum = 1;
        long sum = new long();
        Console.Write("0");
        if (n > 1)
        {
            Console.Write(", 1");
        }
        while (i < n) 
        {
            i++;
            sum = firstNum + secondNum;
            Console.Write(", {0}", sum);
            firstNum = secondNum;
            secondNum = sum;
        } 
    }
}