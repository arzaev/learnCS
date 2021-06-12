using System;

namespace InLesson
{
    class Program
    {

        static void Foo(in int value)
        {
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            int a = 5;
            Foo(a);
        }
    }
}
