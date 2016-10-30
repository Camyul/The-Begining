using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[,] numbers = new int[num, num];
        int col = 0;
        int row = 0;
        string direction = "Right";
        for (int i = 1; i <= num * num; i++)
        {
            if ((direction == "Right" && col >num -1) || (direction == "Right" && numbers[row,col] > 0))
            {
                direction = "Down";
                col--;
                row++;
            }
            if ((direction == "Down" && row > num -1) || (direction == "Down" && numbers[row, col] > 0))
            {
                direction = "Left";
                row--;
                col--;
            }
            if ((direction == "Left" && col < 0) || (direction == "Left" && numbers[row, col] > 0))
            {
                direction = "Up";
                col++;
                row--;
            }
            if ((direction == "Up" && row < 0) || (direction == "Up" && numbers[row, col] > 0))
            {
                direction = "Right";
                row++;
                col++;
            }

            numbers[row,col] = i;

            if (direction == "Right")
            {
                col++;
            }
            else if (direction == "Down")
            {
                row++;
            }
            else if (direction == "Left")
            {
                col--;
            }
            else
            {
                row--;
            }
        }
        for (row = 0;  row < num; row++)
        {
            for (col = 0; col < num; col++)
            {
                Console.Write("{0} ", numbers[row, col]);
            }
            Console.WriteLine();
        }
    }
}