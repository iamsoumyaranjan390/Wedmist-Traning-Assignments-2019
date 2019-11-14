using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn36
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("\nAdding t in between 1st and 2nd letter...");
            inputString = inputString.Insert(1,"t");
            Console.WriteLine("\nThe String after processing is : {0}", inputString);
        }
    }
}
