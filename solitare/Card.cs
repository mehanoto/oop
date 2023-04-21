using System;

namespace solitare
{
    ///Клас карта за игра
    public class Card
    {
        //11->J, 12->Q, 13->K, 1->A
        public int num;
        //1-пика, 2-купа, 3-спатия, 4-каро
        public int colour;

        public Card(int n, int c)
        {
            num = n;
            colour = c;
        }

        /// <summary>
        /// Този метод принтира картата в конзолата
        /// </summary>
        public void print()
        {
            //принтираме картата по-долу е даден кода ако картата е в интервала 2-10, трябва да се погрижим за случаите когато num > 10
            if(num <= 10)
            {
                System.Console.Write(num);
            }
            else
            {
                if(num == 11) 
                {
                    System.Console.Write('J');
                }
                else if(num == 12)
                {
                    System.Console.Write('Q');
                }
                else if(num == 13)
                {
                    System.Console.Write('K');
                }
                else if(num == 14)
                {
                    System.Console.Write('A');
                }
                else 
                {
                    System.Console.Write("No such card! ");
                }
            }

            switch (this.colour)
            {
                case 1:
                    System.Console.Write("Pika");
                    break;
                case 2:
                    System.Console.Write("Kupa");
                    break;
                case 3:
                    System.Console.Write("Spatia");
                    break;
                case 4:
                    System.Console.Write("Karo");
                    break;
                default:
                    System.Console.WriteLine(" : no such suite !");
                    break;
            }
        }



    }
}

