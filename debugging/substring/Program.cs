using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'р';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int subLength = jump;

                    if (subLength > text.Length)
                    {
                        subLength = text.Length;
                    }

                    string matchedString = text.Substring(i, subLength);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
