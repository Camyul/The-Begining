using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        bool isEquals = true;
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isEquals = false;
                break;
            }
        }
        if (isEquals)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}