using System.Collections.Generic;

namespace solitare
{
    ///Клас тесте от карти
    public class Deck
    {
        public List<Card> cardList;

        public bool[] usedCards;

        public Deck()
        {
            //TODO: създайте нов обект от тип списък от карти List<Card> и го запишете в член променливата cardList

            //TODO: използвайте for цикъл, за да изброите картите от 2 до 14, за всяка итерация за цикъла създайте 4-ри карти със същия номер, но различна боя. Добавете създадените обекти в списъка cardList 
        }

        /// <summary>
        /// Този метод принтира картата в конзолата
        /// </summary>
        public Card GetNextCard()
        {
            return null;
        }

        /// <summary>
        /// Този метод принтира картата в конзолата
        /// </summary>
        public void shuffle()
        {

        }

    }
}

