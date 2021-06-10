using System;

namespace IndexArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 5, 35, 2, 53 };
            int[] myArray2 = myArray[1..4];
            Console.WriteLine(myArray[^1]);
        }
    }
}
