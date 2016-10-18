using System;
class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int thirdNumber = (number / 100) % 10;
        if (thirdNumber == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdNumber);
        }
    }
}