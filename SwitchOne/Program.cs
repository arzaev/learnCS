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
                    Console.WriteLine("You typed one");
                    break;
                case 2:
                    Console.WriteLine("You typed two");
                    break;
                default:
                    Console.WriteLine("Number is wrong");
                    break;
            }
        }
    }
}
