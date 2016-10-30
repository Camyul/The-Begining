using System;
class Program
{
    static void Main()
    {
        string binarySequence = Console.ReadLine();
        int[] binarySymbol = new int[binarySequence.Length];
        long decimalNumber = 0;
        for (int i = 0; i < binarySequence.Length; i++)
        {
            binarySymbol[i] = int.Parse(binarySequence.Substring(i, 1));
        }
        for (int i = 0; i < binarySymbol.Length / 2; i++)
        {
            int temp = binarySymbol[i];
            binarySymbol[i] = binarySymbol[binarySymbol.Length -i -1];
            binarySymbol[binarySymbol.Length - i - 1] = temp;
        }
        for (int i = 0; i < binarySequence.Length ; i++)
        {
            if (binarySymbol[i] > 0)
            {
                decimalNumber += (long)Math.Pow(2, i);
            }
        }
        Console.WriteLine(decimalNumber);
    }
}