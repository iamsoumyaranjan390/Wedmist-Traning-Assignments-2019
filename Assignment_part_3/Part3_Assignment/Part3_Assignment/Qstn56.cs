using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn56
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();
            int wordBeg = 0;
            int counter = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ')
                {
                    counter++;
                    if (counter == 1)
                    {
         
                        wordBeg = i;
                        break;
                    }
                    
                }
            }
            char word_beg = inputString[wordBeg + 1];
            char startChar = inputString[0];

            inputString = inputString.Remove(0,1);
            inputString = inputString.Insert(0, word_beg.ToString());
            inputString = inputString.Remove(wordBeg+1,1);
            inputString = inputString.Insert(wordBeg+1,startChar.ToString());

            Console.WriteLine("String after processing is :{0}",inputString);
        }
    }
}
