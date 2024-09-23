using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string opr;

            Console.Write("Enter the 1st number : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Arithematic Operato[/,*,+,-] : ");
            opr = Console.ReadLine();

            Console.Write("Enter the 2nd number : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (opr)
            {
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("We can't divide a number by Zero. Please try another number.");
                    }
                    else
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                default:
                    Console.WriteLine("Invalid Operator !");
                    break;

                    Console.WriteLine();
            }
        }
    }
}
