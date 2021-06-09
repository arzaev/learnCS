using System;
using System.Linq;

namespace realArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 34, 54, 23, 11, 5, 234, 34, 2 };

            int result = myArray.Where(i => i % 2 == 0).Sum();
            Console.WriteLine(result);

        }
    }
}
