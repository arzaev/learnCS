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

            for (int u = 0, j = 5; u < 10 && j < 12; u++, j++)
            {
                Console.WriteLine("u " + u);
                Console.WriteLine("j " + j);
            }

            Console.WriteLine("5 to 0");
            for (int bar = 5; bar >= 0; bar--)
            {
                Console.WriteLine(bar);
            }

            for (int fi = 0, v = 0; fi < 5; fi++, v--)
            {
                Console.WriteLine("v: " + v);
                Console.WriteLine("fi: " + fi);
            }

            Console.ReadLine();
        }
}
}
