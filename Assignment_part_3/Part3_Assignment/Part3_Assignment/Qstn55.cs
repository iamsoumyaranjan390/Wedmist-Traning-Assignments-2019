using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn55
    {
        public static void Answer()
        {
            Console.WriteLine("Taken string is : {Soumya Ranjan}\nDeleting the second word");
            Swaptwostring();
        }
        public static void Swaptwostring()
        {
            string str1 = "Soumya";
            string str2 = "Ranjan";
            str1 += str2;
            str2 = str1.Remove(str1.IndexOf(str2));
            str1 = str1.Substring(str2.Length);
            Console.WriteLine("Output:" + str1 + " " + str2);
        }
    }
}
