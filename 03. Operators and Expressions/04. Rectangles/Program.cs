using System;
class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height =double.Parse(Console.ReadLine());
        Console.Write("{0:F2}", width * height);
        Console.WriteLine(" {0:F2}", 2*(width+height));
    }
}