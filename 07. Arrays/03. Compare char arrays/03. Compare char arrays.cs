using System;
class Program
{
    static void Main()
    {
        string firstSequence = Console.ReadLine();
        string secondSequence = Console.ReadLine();
        char[] firstCharArray = firstSequence.ToCharArray();
        char[] secondCharArray = secondSequence.ToCharArray();
        char lex = new char();

        for (int i = 0; i < Math.Min(firstCharArray.Length, secondCharArray.Length); i++)
        {

            if (firstCharArray[i] == secondCharArray[i])
            {
                lex = '=';
                continue;
            }
            else if (firstCharArray[i] < secondCharArray[i])
            {
                lex = '<';
                break;
            }
            else
            {
                lex = '>';
                break;
            }
        }
        if ((firstCharArray.Length != secondCharArray.Length) && (lex == '='))
        {
            if (firstCharArray.Length > secondCharArray.Length)
            {
                lex = '>';
            }
            else
            {
                lex = '<';
            }
        }
        Console.WriteLine(lex);
    }
    
 }