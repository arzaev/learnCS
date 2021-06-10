using System;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray;
            myArray = new int[3, 5];
            myArray[0, 2] = 99;
            Console.WriteLine(myArray[0, 2]);
        }
    }
}
