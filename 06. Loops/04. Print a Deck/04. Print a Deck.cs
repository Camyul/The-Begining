using System;
class Program
{
    static void Main()
    {
        char card = (char)Console.Read();
        char[] cards = { '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K','A' };
        int i = -1;
        do
        {
            i++;
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
            
        } while (cards[i] != Convert.ToChar(card) && (i < 7));
        if (card == '1' || card == 'J' || card== 'Q' || card=='K' || card=='A')
        {
            Console.WriteLine("10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds");
        }
        while ((i >= 7 && i <= 11) && (cards[i] != Convert.ToChar(card)) && card != '1')
        {
            i++;
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
        }
    }
}