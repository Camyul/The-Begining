using System;
class Program
{
    static void Main()
    {
        int sign = -1;
        int secuence = 0;
        for (int i = 2; i < 12; i++)
        {
            sign *= -1;
            secuence = i * sign;
            Console.WriteLine(secuence);
        }
    }
}