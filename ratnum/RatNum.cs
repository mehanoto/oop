using System;

namespace ratnum
{
    ///Клас рационално число
    public class RatNum
    {
        public int num;
        public int denum;

        //TODO: добавете конструктор по подразбиране,който не приема входни аргументи и инициализира num = 0, denum = 1

        //TODO: добавете конструктор, който приема единствено числителя като аргумент и инициализира num = (предадения аргумент), denum = 1

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
            return res;
        }

        /// <summary>
        /// Този метод изважда стойността на параметъра {other} от текущото рационално число, за което бива извикан метода, 
        /// резултата от извждането се прехвърля в нов обект от тип RatNum, който от своя страна се връща като резултат
        /// </summary>
        public RatNum Substract(RatNum other)
        {
            //TODO: реализирайте метода
            return null;
        }

        /// <summary>
        /// Този метод умножава стойността на текущото рационално число, за което бива извикан метода с това на параметъра {other}
        /// резултата от умножението се прехвърля в нов обект от тип RatNum, който от своя страна се връща като резултат
        /// </summary>
        public RatNum Multiply(RatNum other)
        {
            //TODO: реализирайте метода
            return null;
        }

        /// <summary>
        /// Този метод разделя стойността на текущото рационално число, за което бива извикан метода, с това на параметъра {other} 
        /// резултата от деленето се прехвърля в нов обект от тип RatNum, който от своя страна се връща като резултат
        /// </summary>
        public RatNum Divide(RatNum other)
        {
            //TODO: реализирайте метода
            return null;
        }

        public void print()
        {
            System.Console.WriteLine("{0}/{1}", this.num, this.denum);
        }
    }
}

