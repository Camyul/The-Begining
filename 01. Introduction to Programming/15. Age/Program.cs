using System;
class Program
{
    static void Main()
    {
        DateTime birthDay = Convert.ToDateTime(Console.ReadLine());
        TimeSpan days = (DateTime.Now - birthDay);
        Console.WriteLine(days);
        int years = days.Days / 365;
        Console.WriteLine(years);
        Console.WriteLine(years + 10);
    }
}