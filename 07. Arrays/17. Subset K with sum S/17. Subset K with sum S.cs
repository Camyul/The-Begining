using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        string[] numbers = number.Split(' ');
        int[] nums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }
        int k = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());
        int tempSum = 0;
        string avelibleSum = "no";
        for (int i = 0; i < nums.Length; i++)
        {

            for (int j = i; j <= k; j++)
            {

                if (tempSum < sum)
                {
                    tempSum += nums[j];
                }
                else if (tempSum == sum)
                {
                    avelibleSum = "yes";
                }
                else
                {
                    tempSum = 0;
                    break;
                }
            }
        }
        Console.WriteLine(avelibleSum);
    }
}