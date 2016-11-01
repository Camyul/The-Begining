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
        if (firstCharArray.Length > secondCharArray.Length)
        {
            lex = '>';
        }
        else if (firstCharArray.Length == secondCharArray.Length)
        {
            for (int i = 0; i < firstCharArray.Length; i++)
            {

                if (firstCharArray[i] > secondCharArray[i])
                {
                    lex = '>';
                    break;
                }
                else if (firstCharArray[i] < secondCharArray[i])
                {
                    lex = '<';
                    break;
                }
                else
                {
                    lex = '=';
                }
            }

        }
        else
        {
            lex = '<';
        }
        Console.WriteLine(lex);
    }
}