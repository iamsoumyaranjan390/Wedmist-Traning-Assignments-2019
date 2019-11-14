using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn46
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
            for (j = i; j < inputString.Length; j++)
            {
                if (inputString[j] == 'y')
                    break;
            }
            
            if (i == inputString.Length  || j== inputString.Length)
                Console.WriteLine("There is no string present after 1st x.");
            else
            {
                
                inputString = inputString.Remove(j, 1);
                Console.WriteLine("The string after processing is : {0}", inputString);
            }
        }
    }
}
