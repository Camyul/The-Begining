using System;
class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        number /= 10;
        int a = number % 10;
        Console.WriteLine(a + b + c +d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}