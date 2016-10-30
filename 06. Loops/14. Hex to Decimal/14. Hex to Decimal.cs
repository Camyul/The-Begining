using System;
class Program
{
    static void Main()
    {
        string hexNumbers = Console.ReadLine();
        string[] hexNumber = new string[hexNumbers.Length];
        long decimalNumber = 0;
        for (int i = 0; i < hexNumbers.Length; i++)
        {
            hexNumber[i] = hexNumbers.Substring(i, 1);
        }
        for (int i = 0; i < hexNumbers.Length / 2; i++)
        {
            string temp = hexNumber[i];
            hexNumber[i] = hexNumber[hexNumber.Length - i - 1];
            hexNumber[hexNumber.Length - i - 1] = temp;
        }
        for (int i = 0; i < hexNumber.Length; i++)
        {
            long convertedSymbol = 0;
            switch (hexNumber[i])
            {
                case "0": convertedSymbol = 0;break;
                case "1": convertedSymbol = 1;break;
                case "2": convertedSymbol = 2;break;
                case "3": convertedSymbol = 3;break;
                case "4": convertedSymbol = 4;break;
                case "5": convertedSymbol = 5;break;
                case "6": convertedSymbol = 6;break;
                case "7": convertedSymbol = 7;break;
                case "8": convertedSymbol = 8;break;
                case "9": convertedSymbol = 9;break;
                case "A": convertedSymbol = 10;break;
                case "B": convertedSymbol = 11;break;
                case "C": convertedSymbol = 12;break;
                case "D": convertedSymbol = 13;break;
                case "E": convertedSymbol = 14;break;
                case "F": convertedSymbol = 15;break;
                default:
                    break;
            }
            decimalNumber += convertedSymbol * (long)(Math.Pow(16, i));
        }
        Console.WriteLine(decimalNumber);
    }
}