using System;

namespace ratnum
{
    ///Клас рационално число
    public class RatNum
    {
        public int num;
        public int denum;

        public RatNum()
        {
            this.num = 0;
            this.denum = 1;
        }

        public RatNum(int num)
        {
            this.num = num;
            this.denum = 1;
        }

        public RatNum(int num, int denum)
        {
            this.num = num;
            this.denum = denum;
        }

        /// <summary>
        /// Този метод събира стойността на текущото рационално число, за което бива извикан метода с това, което се предава като входен параметър {other},
        /// резултата от събирането се прехвърля в нов обект от тип RatNum, който от своя страна се връща като резултат
        /// </summary>
        public RatNum Add(RatNum other)
        {
            RatNum res = new RatNum();
            res.num = (this.num * other.denum) + (this.denum * other.num);
            res.denum = this.denum * other.denum;
            int gcd = this.gcd(res.num, res.denum);
            res.num = res.num / gcd;
            res.denum = res.denum / gcd;
            return res;
        }

        /// <summary>
        /// Този метод изважда стойността на параметъра {other} от текущото рационално число, за което бива извикан метода, 
        /// резултата от извждането се прехвърля в нов обект от тип RatNum, който от своя страна се връща като резултат
        /// </summary>
        public RatNum Substract(RatNum other)
        {
            RatNum res = new RatNum();
            res.num = (this.num * other.denum) - (this.denum * other.num);
            res.denum = this.denum * other.denum;
            return res;
        }

        /// <summary>
        /// Този метод умножава стойността на текущото рационално число, за което бива извикан метода с това на параметъра {other}
        /// резултата от умножението се прехвърля в нов обект от тип RatNum, който от своя страна се връща като резултат
        /// </summary>
        public RatNum Multiply(RatNum other)
        {
            RatNum res = new RatNum();
            res.num = this.num * other.num;
            res.denum = this.denum * other.denum;
            return res;
        }

        /// <summary>
        /// Този метод разделя стойността на текущото рационално число, за което бива извикан метода, с това на параметъра {other} 
        /// резултата от деленето се прехвърля в нов обект от тип RatNum, който от своя страна се връща като резултат
        /// </summary>
        public RatNum Divide(RatNum other)
        {
            RatNum res = new RatNum();
            res.num = this.num * other.denum;
            res.denum = this.denum * other.num;
            return res;
        }

        private int gcd(int a, int b)
        {
            int tmp, r;
            if(a < b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            while(b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public void printNorm()
        {
            if(this.denum == 1)
            {
                System.Console.WriteLine(this.num);
            }
            //TODO: продължете
        }

        public void print()
        {
            System.Console.WriteLine("{0}/{1}", this.num, this.denum);
        }
    }
}

