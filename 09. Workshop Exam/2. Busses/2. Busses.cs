﻿using System;
class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int groups = 0;
        int groupSpeed = int.MaxValue;
        for (int i = 0; i < count; i++)
        {
            int busSpeed = int.Parse(Console.ReadLine());
            if (busSpeed <= groupSpeed)
            {
                groupSpeed = busSpeed;
                groups++;
            }
        }
        Console.WriteLine(groups);
    }
}