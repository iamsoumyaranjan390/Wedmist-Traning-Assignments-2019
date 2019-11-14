using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn50
    {
        public static void Answer()
        {

        }

        public static void Lexicographicallysmallestandlargest()
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the value of k:");
            int k = int.Parse(Console.ReadLine());
            String currStr = s.Substring(0, k);
            String lexMin = currStr;
            String lexMax = currStr;

            // Consider all remaining substrings.  
            // We consider every substring  
            // ending with index i.  
            for (int i = k; i < s.Length; i++)
            {
                currStr = currStr.Substring(1, k - 1) + "" + s[i];
                if (CompareTo(lexMax, currStr) < 0)
                    lexMax = currStr;
                if (CompareTo(lexMin, currStr) > 0)
                    lexMin = currStr;
            }

            // Print result. 
            Console.WriteLine("The largest string is:" + lexMax);
            Console.WriteLine("The smallest string is:" + lexMin);

        }
        public static int CompareTo(String s1, String s2)
        {
            for (int i = 0; i < s1.Length || i < s2.Length; i++)
            {
                if (s1[i] < s2[i])
                    return -1;
                else if (s1[i] > s2[i])
                    return 1;
            }
            return 0;
        }
    }
}
