using System.Collections.Generic;
using System;

namespace solitare
{
    ///Клас тесте от карти
    public class Deck
    {
        public List<Card> cardList;

        public bool[] usedCards;

        private int counterUsedCards;

        public Deck()
        {
            this.cardList = new List<Card>();
            for (int num = 2; num <= 14; num++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    this.cardList.Add(new Card(num, c));
                }
            }
            this.usedCards = new bool[this.cardList.Count];
            this.counterUsedCards = 0;
        }

        /// <summary>
        /// Връща една от неизползваните карти на произволен принцип или null ако всички карти са използвани
        /// </summary>
        public Card GetNextCard()
        {
            if(counterUsedCards < cardList.Count)
            {
                Random rnd = new Random();
                int i = rnd.Next(this.cardList.Count);
                while (this.usedCards[i])
                {
                    i++;
                    if (i >= this.usedCards.Length)
                    {
                        i = 0;
                    }
                }

            }
            return null;
        }



        /// <summary>
        /// Връща истина ако има още карти за теглене и лъжа ако няма.
        /// </summary>
        public bool HasMoreCards()
        {
            return this.counterUsedCards < this.cardList.Count;
        }

        /// <summary>
        /// Този метод "Рестартира" броенето 
        /// </summary>
        public void Reset()
        {
            this.counterUsedCards = 0;
            for (int i = 0; i < this.usedCards.Length; i++)
            {
                this.usedCards[i] = false; 
            }
        }

    }
}

