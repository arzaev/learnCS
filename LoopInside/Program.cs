using System;

namespace LoopInside
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Loop 1 interation " + i);
            //    for (int j = 0; j <= 3; j++)
            //    {
            //        Console.WriteLine("\tLoop 2 interation " + j);

            //        for (int k = 0; k < 2; k++)
            //        {
            //            Console.WriteLine("\t\tLoop 2 interation " + k);
            //        }
            //    }
            //}

            Console.WriteLine("height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("width: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            

            Console.ReadLine();
        }
    }
}
