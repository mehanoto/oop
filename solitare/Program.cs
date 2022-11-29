using System;

namespace solitare
{
    class Program
    {
        static void Main(string[] args)
        {
            //двойка купа
            Card hearts2 = new Card(2, 2);
            hearts2.print();

            //двойка каро
            Card tiles2 = new Card(2, 4);
            tiles2.print();
            
            //двойка спатия
            Card clovers2 = new Card(2,2);
            clovers2.print();
            
            //двойка пика
            Card pikes2 = new Card(2,2);
            pikes2.print();

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
