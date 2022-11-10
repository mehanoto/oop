using System;

namespace solitare
{
    ///Клас карта за игра
    public class Card
    {
        //11->J, 12->Q, 13->K, 14->A
        public int num;
        //1-пика, 2-купа, 3-спатия, 4-каро
        public int colour;

        public Card(int n, int c)
        {

        }

        /// <summary>
        /// Този метод принтира картата в конзолата
        /// </summary>
        public void print()
        {
            //принтираме картата по-долу е даден кода ако картата е в интервала 2-10, трябва да се погрижим за случаите когато num > 10
            if(num <= 10)
            {
                System.Console.WriteLine(num);
            }
            else
            {
                //TODO: принтирайте картата ако е J, Q, K, A
            }

            
            //TODO: принтирайте боята 1-пика, 2-купа, 3-спатия, 4-каро
            
        }



    }
}

