using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn49
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();
            char left=' ', right=' ';
            char firstChar = inputString[0];
            int i = -1;
            for ( i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] == firstChar)
                {
                    left = inputString[i - 1];
                    right = inputString[i+1];
                    break;
                }
            }
            if (i == inputString.Length)
                Console.WriteLine("2nd time letter is not repeated.");
            else
            {
                int left_1st = -1, right_1st = -1;
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == left)
                        left_1st = j;
                }

                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == right)
                        right_1st = j;
                }
                if(left<right)
                    Console.WriteLine("The String in between : {0}",inputString.Substring(left,right));
                else
                    Console.WriteLine("The String in between : {0}", inputString.Substring(right,left));
            }
        }
    }
}
