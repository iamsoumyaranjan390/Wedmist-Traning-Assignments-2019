﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn41
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("\nFinding the 2nd x...");
            int i;
            int counter = 0;
            for (i = 0; i < inputString.Length; i++)
            {               
                if (inputString[i] == 'x')
                {
                    counter++;
                    if (counter == 2)
                        break;
                }
            }
            if (i == inputString.Length + 1)
                Console.WriteLine("There is no second x");
            else
            {
                Console.WriteLine("The string after second x is : {0}", inputString.Substring(i + 1));
            }
        }
    }
}
