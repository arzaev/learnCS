using System;
using System.Linq;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5] {5, 6, 7, 5, 3 };

            int[] myArray2 = Enumerable.Range(4, 5).ToArray();

            Console.ReadLine();
        }
    }
}
