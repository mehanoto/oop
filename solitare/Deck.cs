using System.Collections.Generic;
using System;

namespace solitare
{
    ///Клас тесте от карти
    public class Deck
    {
        public List<Card> cardList;

        public int NumberOfCards
        {
            get
            {
                //връща бройката карти оставащи в тестето
                return 0;
            }
        }

        public Deck()
        {
            this.cardList = new List<Card>();
            for (int num = 1; num <= 13; num++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    this.cardList.Add(new Card(num, c));
                }
            }
            this.Shuffle();
        }

        /// <summary>
        /// Връща една от неизползваните карти на произволен принцип или null ако всички карти са използвани
        /// </summary>
        public Card GetNextCard()
        {
            return null;
        }

        /// <summary>
        /// Премахва картата cToRemove от списъка с карти и връща true при успешно премахване, иначе false
        /// </summary>
        /// <param name="cToRemove"></param>
        /// <returns></returns>
        public bool RemoveCard(Card cToRemove)
        {

            

            return false;
        }

        /// <summary>
        /// Връща истина ако има още карти за теглене и лъжа ако няма.
        /// </summary>
        public bool HasMoreCards()
        {
            return cardList.Count > 0;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < cardList.Count - 1; i++)
            {
                int j = rnd.Next(i + 1, cardList.Count);
                Card temp = cardList[i];
                cardList[i] = cardList[j];
                cardList[j] = temp;
            }
        }

    }
}

