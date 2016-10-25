using System;
class Program
{
    static void Main()
    {
        string typeOfVariable = Console.ReadLine();
        if (typeOfVariable == "integer")
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + 1);
        }
        else if (typeOfVariable == "real")
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", number + 1);
        }
        else
        {
            string sequence = Console.ReadLine();
            Console.WriteLine(sequence + "*");
        }
    }
}