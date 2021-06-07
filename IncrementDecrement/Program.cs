using System;

namespace IncrementDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            a = ++a * a; // 4
            // a = a++ * a; --> 2

            Console.WriteLine(a);
        }
    }
}
