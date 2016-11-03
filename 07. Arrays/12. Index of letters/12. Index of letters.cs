using System;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        char[] letters = word.ToCharArray();
        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine((int)letters[i] - 97);
        }
    }
}