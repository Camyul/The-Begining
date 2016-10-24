using System;
class Program
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhone = Console.ReadLine();
        string companyFax = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirsName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax: {0}", (companyFax != "") ? companyFax : "(no fax)");
        Console.WriteLine("Web site: {0}", webSite);
        Console.Write("Manager: {0} {1} (age: {2}, tel. {3})",managerFirsName, managerLastName, managerAge, managerPhone);
    }
}