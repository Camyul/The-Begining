using System;


class Program
{
    static void Main()
    {

        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        int years = (int)((DateTime.Now.AddMonths(-7) - BirthDay).TotalDays / 365.242199);
        Console.WriteLine(years);
        Console.WriteLine(years + 10);
    }
}