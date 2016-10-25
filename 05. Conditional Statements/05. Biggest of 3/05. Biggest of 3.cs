using System;
class Program
{
    static void Main()
    {
        double numberOne = Convert.ToDouble(Console.ReadLine());
        double numberTwo = Convert.ToDouble(Console.ReadLine());
        double numberThree = Convert.ToDouble(Console.ReadLine());
        if (numberOne >= numberTwo)
        {
            if (numberOne >= numberThree)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberThree);
            }
        }
        else
        {
            if (numberTwo >= numberThree)
            {
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberThree);
            }
        }
    }
}