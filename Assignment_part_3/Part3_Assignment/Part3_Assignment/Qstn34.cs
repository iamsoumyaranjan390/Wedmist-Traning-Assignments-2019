using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    class Qstn34
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("\nExchanging the 1st two letters in the beginning...");
            char c = inputString[0];
            
            String modified=inputString.Remove(0,1);
            String ans=modified.Insert(1, c.ToString());
            Console.WriteLine("The String after processing is : {0}",ans);
        }
    }
}
