using System;

namespace ratnum
{
    public class RatNum
    {
        public int num;
        public int denum;

        public RatNum(int num, int denum)
        {
            
        }

        //TODO: добавете конструктор, който приема единствено числителя като аргумент

        public RatNum Add(RatNum other)
        {
            return null;
        }

        public RatNum Substract(RatNum other)
        {
            return null;
        }

        public RatNum Multiply(RatNum other)
        {
            return null;
        }

        public RatNum Divide(RatNum other)
        {
            return null;
        }

        public void print()
        {
            System.Console.WriteLine("{0}/{1}", this.num, this.denum);
        }
    }
}