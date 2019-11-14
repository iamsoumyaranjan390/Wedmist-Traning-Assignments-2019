using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn38
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            Console.WriteLine("\nReplacing the first x by y...");
            int i;
            for (i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'x')
                    break;
            }
            inputString = inputString.Replace(inputString[i],'y');
            Console.WriteLine("The string aftrer processing: {0}",inputString);
        }
    }
}
