using System;
class Program
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');
        int firstNum = int.Parse(num[0]);
        int secondNum = int.Parse(num[1]);
        int rest = 1;
        while (rest > 0)
        {
            rest = firstNum % secondNum;
            firstNum = secondNum;
            secondNum = rest;
        }
        Console.WriteLine(firstNum);
    }
}