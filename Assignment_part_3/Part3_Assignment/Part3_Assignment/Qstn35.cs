using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    class Qstn35
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("\nExchanging the 1st two letters in the beginning...");
            char c_4 = inputString[3];
            char c_10 = inputString[9];
            String modified = inputString.Remove(3, 1);
            modified = modified.Remove(8, 1);
            String ans = modified.Insert(3, c_10.ToString());
            ans = ans.Insert(9,c_4.ToString());
            Console.WriteLine("The String after processing is : {0}", ans);
        }
    }
}
