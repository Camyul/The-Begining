using System;
class Program
{
    static void Main()
    {
        double numberOne = Convert.ToDouble(Console.ReadLine());
        double numberTwo = Convert.ToDouble(Console.ReadLine());
        double numberThree = Convert.ToDouble(Console.ReadLine());
        double numberFour = Convert.ToDouble(Console.ReadLine());
        double numberFive = Convert.ToDouble(Console.ReadLine());
        double biggestNumber = 0;
        if (numberOne >= numberTwo)
        {
            if (numberOne >= numberThree)
            {
                biggestNumber = numberOne;
            }
            else
            {
                biggestNumber = numberThree;
            }
        }
        else
        {
            if (numberTwo >= numberThree)
            {
                biggestNumber = numberTwo;
            }
            else
            {
                biggestNumber = numberThree;
            }
        }
        if (numberFour >= numberFive)
        {
            Console.WriteLine(Math.Max(numberFour, biggestNumber));
        }
        else
        {
            Console.WriteLine(Math.Max(numberFive, biggestNumber));
        }
    }
}