using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn32
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("Removing the 2nd letter.....");
            Console.WriteLine("The String after processing : {0}",inputString.Remove(1,1));
        }
    }
}
