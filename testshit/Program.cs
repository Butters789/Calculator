using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static float firstNumber;
        static float secondNumber;
        static float restart = 1;
        static string calculationMethod;

        static void Main(string[] args)
        {
            while (restart == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("I am your Calculator, Please give me your first number.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("");
                Console.Write("> ");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Now, Choose your second number");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("");
                Console.Write("> ");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("What calculation method do you want to use? + - * /");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("");
                Console.Write("> ");
                calculationMethod = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Your Answer to this calculation is");
                CalculationAnswer();
            }
        }
            

            static void CalculationAnswer()
            {

                if (calculationMethod == "+")
                {
                    Console.WriteLine("{0}", firstNumber + secondNumber);
                    Console.WriteLine();
                    Console.WriteLine("If you wish for another calculation press [Enter]");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }

                else if (calculationMethod == "-")
                {
                    Console.WriteLine("{0}", firstNumber - secondNumber);
                    Console.WriteLine();
                    Console.WriteLine("If you wish for another calculation press [Enter]");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }

                else if (calculationMethod == "*")
                {
                    Console.WriteLine("{0}", firstNumber * secondNumber);
                    Console.WriteLine();
                    Console.WriteLine("If you wish for another calculation press [Enter]");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }

                else if (calculationMethod == "/")
                {
                    Console.WriteLine("{0}", firstNumber / secondNumber);
                    Console.WriteLine();
                    Console.WriteLine("If you wish for another calculation press [Enter]");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }

            }

        }
           
 }
    

