using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn33
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("\nAdding the 0th letter in the beginning...");
            inputString = inputString[0] + inputString;
            Console.WriteLine("\nThe String after processing is : {0}",inputString);
        }
    }
}
