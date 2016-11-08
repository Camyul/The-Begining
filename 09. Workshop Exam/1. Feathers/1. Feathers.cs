using System;
class Program
{
    static void Main()
    {
        double birds = double.Parse(Console.ReadLine());
        double feathers = double.Parse(Console.ReadLine());

        if (birds == 0)
        {
            Console.WriteLine("0");
        }
        else if (birds % 2 == 0)
        {
            Console.WriteLine("{0:F4}", (feathers / birds)*123123123123);
        }
        else
        {
            Console.WriteLine("{0:F4}", (feathers / birds) / 317);
        }
    }
}