using System;
class Program
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        string[] arr = sequence.Split(' ');
        int[] intArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            intArr[i] = int.Parse(arr[i]);
        }
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                sum += intArr[j];
                if (sum < 11)
                {
                    continue;
                }
                else if (sum > 11)
                {
                    break;
                }
                else
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write("{0} ", intArr[k]);
                    }
                    return;
                }
            }
        }
    }
}