using System;

namespace Ref
{
    class Program
    {

        //static void Foo(ref int a)
        //{
             
        //}

        //static void Main(string[] args)
        //{
        //    int a = 2;

        //    Foo(ref a);

        //    Console.WriteLine(a);
        //}

        static ref int Foo(int[] numbers)
        {
            return ref numbers[0];
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 6, 1 };
            ref int b = ref Foo(arr);

            b = -5;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
