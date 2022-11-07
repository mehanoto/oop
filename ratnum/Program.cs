using System;

namespace ratnum
{
    class Program
    {
        static void Main(string[] args)
        {
            RatNum oneHalf = new RatNum(1, 2);
            RatNum threeFourth = new RatNum(3, 4);
            RatNum oneFourth = new RatNum(1, 4);

            RatNum res = oneHalf.Add(oneFourth);
            res.print();

            res = oneHalf.Substract(oneFourth);
            res.print();

            res = oneHalf.Multiply(oneFourth);
            res.print();

            res = oneHalf.Divide(threeFourth);
            res.print();
        }
    }
}
