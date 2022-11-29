using System.Collections.Generic;

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
            //TODO: създайте нова инстанция на класа List<Card> и го запишете в член променливата cardList

            //TODO: използвайте for цикъл, за да изброите картите от 2 до 14, за всяка итерация за цикъла създайте 4-ри карти със същия номер, но различна боя. Добавете създадените обекти в списъка cardList 
        }

        /// <summary>
        /// Връща една от неизползваните карти на произволен принцип или null ако всички карти са използвани
        /// </summary>
        public Card GetNextCard()
        {
            if(counterUsedCards < cardList.Count)
            {
                //TODO: get next cards
            }
            return null;
        }

        /// <summary>
        /// Връща истина ако има още карти за теглене и лъжа ако няма.
        /// </summary>
        public bool HasMoreCards()
        {
            
        }

        /// <summary>
        /// Този метод "Рестартира" броенето 
        /// </summary>
        public void Reset()
        {

        }

    }
}

