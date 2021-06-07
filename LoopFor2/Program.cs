using System;

namespace LoopFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int limit = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < limit; i++)
            //    {

            //    }

            int i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("for 1: " + i);
            }

            for (; i < 5; i++)
            {
                Console.WriteLine("for 2: " + i);
            }

            for (int u = 0, j = 5; u < 10; u++)
            {
                Console.WriteLine("u " + u);
                Console.WriteLine("j " + j);
            }

            Console.ReadLine();
        }
}
}
