# Упражнение методи конструктори
Нека разгледаме познатото ни от математиката рационално число или (правилна дроб). Всяко такова число има двe отличителни характеристики, числител и знаменател, като съществува ограничението към знаменателя да бъде различен от нула. Примери за такива числа са: 1/2, 3/4, 7/8 и т.н.

Действията, които можем да извършваме с рационалните числа включват събиране, изваждане, умножение и деление. 

Значимите атрибути за новия клас рационално число RatNum са числителя и знаменятеля (num, denum), тези атрибути дефинират състоянието на обектите от този клас, освен атрибути също употребяваме съответно термина член променливи или данни. Тези атрибути са включени в класа RatNum, който се намира в изходния код във файла RatNum.cs.

От друга страна изредихме действията, които ще обособим в съответни методи в класа Ratnum:
- Събиране -> метод Add
- Изваждане -> метод Substract
- Умноженеи -> метод Multiply
- Деление -> метод Divide

По-долу е даден изходния код на класа RatNum, вашата задача е да замените всяка //TODO: инструкция, с кода който реализира съответната инструкция, като за ориентир имате реализиран метода Add и конструктора, който приема два параметъра, като вашата задача е да довършите останалите методи/конструктори според инструкциите.
```
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
```

[note]:
    Не се притеснявайте от компилационната грешка, ако изпълните инструкциите би трябвалод а се оправи.
    Ако сте работили правилно, след като стартирате проекта като конзолно приложение или с други думи изпълните главния метод Main(), би трябвало да видите като резултат дробните числа от изчисленията, които се извършват в Main() метода, а именно -> 6/8 2/8 1/8 4/6 
