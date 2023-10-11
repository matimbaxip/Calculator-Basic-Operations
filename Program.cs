using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Basic_Operations
{
    internal class Program

        // Calculator using Basic operators
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator. (+, -, / or *) ");
            string op = Console.ReadLine();
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if (op == "+")
            {
                double add = num1 + num2;
                Console.WriteLine("Your sum is :" + add);
            }
            else if (op == "-")
            {
                double subtraction = num1 - num2;
                Console.WriteLine("Your Difference is: " + subtraction);
            }
            else if (op == "*")
            {
                double multiply = num1 * num2;
                Console.WriteLine("Your product is: " + multiply);
            }
            else if (op == "/")
            {
                double division = num1 / num2;
                Console.WriteLine("Your division is: " + division);
            }
            else
                Console.WriteLine("Enter the available operator!");
        }
    }
}
