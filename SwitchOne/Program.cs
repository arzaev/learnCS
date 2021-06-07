using System;

namespace SwitchOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("You are typed number one or two");
                    break;
                default:
                    Console.WriteLine("Number is wrong");
                    break;
            }

            string b = Console.ReadLine();
            
            switch (b)
            {
                case "+":
                    Console.WriteLine("You are typed +");
                    break;
            }
                
            }
        }
    }
