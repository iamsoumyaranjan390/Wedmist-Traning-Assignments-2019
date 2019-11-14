using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn44
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
            char c_pre = inputString[i-1];
            char c_post = inputString[i + 1];

            inputString = inputString.Remove(i - 1,1);
            inputString = inputString.Remove(i + 1,1);
            inputString = inputString.Insert(i-1,c_post.ToString());
            inputString = inputString.Insert(i+1,c_pre.ToString());
            Console.WriteLine("String after processing is : {0}",inputString);
        }
    }
}
