using System;

namespace solitare
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            while(deck.HasMoreCards())
            {
                Card c = deck.GetNextCard();
                c.print();
                System.Console.WriteLine();
            }

        }
    }
}
