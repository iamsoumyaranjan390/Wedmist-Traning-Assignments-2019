using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn45
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            char c = inputString[0];
            int i;
            for ( i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] == c)
                {
                    Console.WriteLine("2nd location Found at position : {0}",i+1);
                    break;
                }
            }
            if (i == inputString.Length + 1)
                Console.WriteLine("Not found");
        }
    }
}
