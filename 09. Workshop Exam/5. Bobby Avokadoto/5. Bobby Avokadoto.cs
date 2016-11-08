using System;
class Program
{
    static void Main()
    {
        uint head = uint.Parse(Console.ReadLine());
        uint combCount = uint.Parse(Console.ReadLine());
        uint bestComb = 0;
        uint bestCount = 0;

        for (int i = 0; i < combCount; i++)
        {
            uint comb = uint.Parse(Console.ReadLine());
            if ((head & comb) == 0)
            {//comb is valid
                //count teech
                uint currentCount = 0;
                for (int j = 0; j < 32; j++)
                {
                    currentCount += (comb>>j) &  1;

                }
                //check if best
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestComb = comb;
                }
            }
        }
        Console.WriteLine(bestComb);
    }
}