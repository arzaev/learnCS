using System;

namespace IfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = false;

            if (isInfected)
            {
                Console.WriteLine("Player is infected");
            }
            else
            {
                Console.WriteLine("Player is okay!");
            }


            int a;
            a = int.Parse(Console.ReadLine());
            if (a == 5)
            {
                Console.WriteLine("a eaqle 5");
            }
            else
            {
                Console.WriteLine("a is not eaqle 5");
            }
        }
    }
}
