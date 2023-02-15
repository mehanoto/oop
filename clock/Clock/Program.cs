using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Time c1 = new Time();
            c1.SetTime(3, 20);
            c1.AddMinutes(1);
            Console.WriteLine(c1.ToString());

            Time c2 = new Time();
            c2.SetTime(3, 22);

            if (c1.Equals(c2)) 
            {
                Console.WriteLine("success !");
            }



        }
    }
}
