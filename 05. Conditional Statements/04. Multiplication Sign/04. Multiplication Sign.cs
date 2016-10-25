using System;
class Program
{
    static void Main()
    {
        double numberOne = Convert.ToDouble(Console.ReadLine());
        double numberTwo = Convert.ToDouble(Console.ReadLine());
        double numberThree = Convert.ToDouble(Console.ReadLine());
        if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
        {
            Console.WriteLine(0);
        }
        else if (numberOne < 0 || numberTwo < 0 || numberThree < 0)
        {
            int count = 0;
            if (numberOne < 0)
            {
                count++;
            }
            if (numberTwo < 0)
            {
                count++;
            }
            if (numberThree < 0)
            {
                count++;
            }
            if (count % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}