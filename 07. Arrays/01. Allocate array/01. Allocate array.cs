using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = 5 * i;
            Console.WriteLine(numbers[i]);
        }
    }
}