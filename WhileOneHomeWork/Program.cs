using System;

namespace WhileOneHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Type limit number");
            int limit = int.Parse(Console.ReadLine());
            while(count < limit)
            {
                count++;
                if (count % 2 == 0)
                {
                    Console.WriteLine(count + " is even");
                }
                else
                {
                    Console.WriteLine(count + " is not even");
                }
            }
        }
    }
}
