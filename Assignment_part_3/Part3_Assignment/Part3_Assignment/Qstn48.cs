using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn48
    {
        public static void Answer()
        {
            String inputString;
            Console.WriteLine("Enter the string : ");
            inputString = Console.ReadLine();
            int counter = 0;
            int left=0,right=0;
            char left_1st_x=' ', right_2nd_x=' ';
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'x')
                {
                    counter++;
                    if (counter == 1)
                    {
                        left = i - 1;
                        left_1st_x = inputString[i-1];
                    }

                    if (counter == 2)
                    {
                        right_2nd_x = inputString[i+1];
                        break;
                    }
                }
            }
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == right_2nd_x)
                {
                    right = i;
                    break;
                }
            }
           inputString= inputString.Remove(right,1);
           inputString= inputString.Insert(right, left_1st_x.ToString());
            Console.WriteLine("The string after processing is :{0}",inputString);
        }
    }
}
