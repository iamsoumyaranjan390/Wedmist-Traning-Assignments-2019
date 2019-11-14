using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn54
    {
        public static void Answer()
        {
            Console.WriteLine("Taken string is : {Soumya Ranjan Mohanty}\nDeleting the second word");
            Removesecond();
        }

        public static void Removesecond()
        {
            string str = "Soumya Ranjan Mohanty";
            Console.WriteLine(str.Remove(7, 7));
        }
    }
}
