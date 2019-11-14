using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn40
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();

            int i;
            for (i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'x')
                    break;
            }

            int j;
            for (j = i+1; j < inputString.Length; j++)
            {
                if (inputString[j] == 'x')
                    break;
            }
            Console.WriteLine("The string between 1st and 2nd x is : {0}",inputString.Substring(i+1,j-i-1));
        }
    }
}
