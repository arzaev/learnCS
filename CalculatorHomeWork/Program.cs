using System;

namespace CalculatorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Type math sign");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine("result is " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("result is " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("result is " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("result is " + (a / b));
                    break;
                default:
                    break;
            }
        }
    }
}
