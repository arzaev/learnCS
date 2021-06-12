using System;

namespace OutRefLesson
{
    class Program
    {

        static void Foo(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }

        static void Bar(out int value)
        {
            value = 5;
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            //int a = 10;
            //Foo(ref a);
            //Console.WriteLine(a);

            //int a;
            //Bar(out a);
            //Console.WriteLine(a);

            string str = Console.ReadLine();
            int.TryParse(str, out int result);
            Console.WriteLine(result);
        }
    }
}
