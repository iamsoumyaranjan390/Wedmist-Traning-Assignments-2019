using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn51
    {
        public static void Answer()
        {
            Comparestrings();
        }

        public static void Comparestrings()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            int lenstr1 = str1.Length;
            int lenstr2 = str2.Length;


            if (lenstr1 > lenstr2)
            {
                Console.WriteLine("1");
            }
            else if (lenstr2 > lenstr1)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
