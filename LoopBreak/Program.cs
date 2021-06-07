using System;

namespace LoopBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                string msg = Console.ReadLine();
                if(msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
