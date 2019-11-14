using System;
using System.Collections.Generic;
using System.Text;

namespace Part3_Assignment
{
    static class Qstn60
    {
        public static void Answer()
        {
            Square();
        }

        public static void Square()
        {
            Console.WriteLine("Enter the number you want to be squared.");
            int number = int.Parse(Console.ReadLine());
            number *= number;
            Console.WriteLine("Your result is:" + number);
        }
    }

}
