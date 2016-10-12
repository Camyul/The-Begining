using System;
class Program
{
    static void Main()
    {
        DateTime birthDay = Convert.ToDateTime(Console.ReadLine());
        DateTime dateNow = DateTime.Now;
        TimeSpan diff = (dateNow - birthDay);
        int years = (dateNow - diff).Year;
        Console.WriteLine(years);
        Console.WriteLine(years + 10);
    }
}