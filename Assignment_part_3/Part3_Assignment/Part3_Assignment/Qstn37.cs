using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn37
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("\nFinding the string after1st x...");
            int i;
            for (i = 0; i < inputString.Length; i++)
            {

                if (inputString[i] == 'x')
                    break;
            }
            if (i == inputString.Length)
                Console.WriteLine("x is  not found or present in the last position. Nothing to display.");
            else
            {
                Console.WriteLine("the string after x is :{0}", inputString.Substring(i + 1));
            }

        }
    }
}
