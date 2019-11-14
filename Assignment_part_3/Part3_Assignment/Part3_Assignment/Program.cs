using System;

namespace Part3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String inputChoice;
            Console.WriteLine("-------------part-2 of assignment containing Questions 32 to 60---------------- \n");
            Console.Write("enter the serial number of question you want (0 to exit): ");
            inputChoice = Console.ReadLine();
            Console.WriteLine();
            choice = Convert.ToInt32(inputChoice);
            while (choice != 0)
            {
                switch (choice)
                {
                     case 32:
                         Qstn32.Answer();
                         break;
                      case 33:
                          Qstn33.Answer();
                          break;
                      case 34:
                          Qstn34.Answer();
                          break;
                     case 35:
                         Qstn35.Answer();
                         break;
                     case 36:
                         Qstn36.Answer();
                         break;
                     case 37:
                         Qstn37.Answer();
                         break;
                     case 38:
                        Qstn38.Answer();
                        break;
                     case 39:
                         Qstn39.Answer();
                         break;
                     case 40:
                         Qstn40.Answer();
                         break;
                    case 41:
                        Qstn41.Answer();
                        break;
                    case 42:
                        Qstn42.Answer();
                        break;
                     case 43:
                         Qstn43.Answer();
                         break;
                     case 44:
                         Qstn44.Answer();
                        break;
                    case 45:
                        Qstn45.Answer();
                        break;
                    case 46:
                        Qstn46.Answer();
                        break;
                    case 48:
                        Qstn48.Answer();
                        break;
                    case 49:
                        Qstn49.Answer();
                        break;
                    case 50:
                        Qstn50.Answer();
                        break;
                    case 51:
                        Qstn51.Answer();
                        break;
                    case 52:
                        Console.WriteLine("Refer to Qstn 51.");
                        break;
                    case 53:
                        Qstn53.Answer();
                        break;
                    case 54:
                        Qstn54.Answer();
                        break;
                    case 55:
                        Qstn55.Answer();
                        break;
                    case 56:
                        Qstn56.Answer();
                        break;
                    case 57:
                        Qstn57.Answer();
                        break;
                    case 60:
                        Qstn60.Answer();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.Write("\n\nenter the serial number of question you want (0 to exit): ");
                inputChoice = Console.ReadLine();
                Console.WriteLine();
                choice = Convert.ToInt32(inputChoice);
            }
        }
    }
}
