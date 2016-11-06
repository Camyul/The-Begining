using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        string[] letters = new string[sequence.Length];
        for (int j = 0; j < sequence.Length; j++)
        {
            letters[j] = sequence.Substring(j, 1);
        }
        
        int result = int.Parse(letters[0]);
        int digit = 0;
        int i = 0;
        string letter = letters[i + 1];
        do
        {
            
            bool notDigit = int.TryParse(letter, out digit);
            if (!notDigit)
            {
                if (letter == "+")
                {
                    if (letters[i + 2] == "(")
                    {

                    }
                    else if (letters[i + 2] == "=")
                    {
                        break;
                    }
                    else
                    {
                        result += int.Parse(letters[i + 2]);
                        i += 2;
                    }

                }
                if (letter == "-")
                {
                    if (letters[i + 2] == "(")
                    {

                    }
                    else if (letters[i + 2] == "=")
                    {
                        break;
                    }
                    else
                    {
                        result -= int.Parse(letters[i + 2]);
                        i += 2;
                    }

                }
                if (letter == "*")
                {
                    if (letters[i + 2] == "(")
                    {

                    }
                    else if (letters[i + 2] == "=")
                    {
                        break;
                    }
                    else
                    {
                        result *= int.Parse(letters[i + 2]);
                        i += 2;
                    }

                }
                if (letter == "/")
                {
                    if (letters[i + 2] == "(")
                    {

                    }
                    else if (letters[i + 2] == "=")
                    {
                        break;
                    }
                    else
                    {
                        result /= int.Parse(letters[i + 2]);
                        i += 2;
                    }

                }
            }
            i++;
            letter = letters[i + 1];
        }
        while (letter != "=");
        Console.WriteLine(result);
    }
}