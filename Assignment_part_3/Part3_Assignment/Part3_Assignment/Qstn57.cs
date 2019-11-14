using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn57
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();
            int wordBeg = 0,wordEnd=0;
            int counter = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                
                if (inputString[i] == ' ')
                {
                    counter++;
                    if (counter == 1)
                    {

                        wordBeg = i;
                       
                    }
                    else if(counter==2)
                    {
                        wordEnd = i;
                        break;
                    }

                }
            }
            Console.WriteLine("wordend:{0} wordbeg:{0}", wordEnd, wordBeg);
            char word_end_1st = inputString[wordBeg - 1];
            char word_end_2nd = inputString[wordEnd-1];

            inputString = inputString.Remove(wordEnd - 1, 1);
            inputString = inputString.Insert(wordEnd - 1, word_end_1st.ToString());
            inputString = inputString.Remove(wordBeg - 1, 1);
            inputString = inputString.Insert(wordBeg - 1, word_end_2nd.ToString());

                Console.WriteLine("String after processing is :{0}", inputString);
            
        }
    }
}
