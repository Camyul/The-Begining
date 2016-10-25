using System;
class Program
{
    static void Main()
    {
        double numberOne = Convert.ToDouble(Console.ReadLine());
        double numberTwo = Convert.ToDouble(Console.ReadLine());
        double numberThree = Convert.ToDouble(Console.ReadLine());
        //if (numberOne < numberTwo)
        //{
        //    numberOne = numberOne + numberTwo;
        //    numberTwo = numberOne - numberTwo;
        //    numberOne = numberOne - numberTwo;
        //}
        //if (numberTwo < numberThree)
        //{
        //    numberTwo = numberTwo + numberThree;
        //    numberThree = numberTwo - numberThree;
        //    numberTwo = numberTwo - numberThree;
        //}
        //if (numberOne < numberTwo)
        //{
        //    numberOne = numberOne + numberTwo;
        //    numberTwo = numberOne - numberTwo;
        //    numberOne = numberOne - numberTwo;
        //}
        //Console.WriteLine("{0} {1} {2}", numberOne, numberTwo, numberThree);
        double maxNum = new double();
        double middleNum = new double();
        double minNum = new double();
        if (numberOne >= numberTwo)
        {
            if (numberOne >= numberThree)
            {
                maxNum = numberOne;
                if (numberTwo >= numberThree)
                {
                    middleNum = numberTwo;
                    minNum = numberThree;
                }
                else
                {
                    minNum = numberTwo;
                    middleNum = numberThree;
                }
            }
            else
            {
                maxNum = numberThree;
                middleNum = numberOne;
                minNum = numberTwo;
            }
        }
        else
        {
            if (numberTwo >= numberThree)
            {
                maxNum = numberTwo;
                if (numberOne >= numberThree)
                {
                    middleNum = numberOne;
                    minNum = numberThree;
                }
                else
                {
                    minNum = numberOne;
                    middleNum = numberThree;
                }
            }
            else
            {
                maxNum = numberThree;
                middleNum = numberTwo;
                minNum = numberOne;
            }
        }
        Console.WriteLine("{0} {1} {2}", maxNum, middleNum, minNum);
    }
}