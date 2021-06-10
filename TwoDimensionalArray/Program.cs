using System;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray;
            myArray = new int[,]
            {
                {1, 45, 12, 51, 453 },
                {112, 43, 1, 214, 123 },
                {17, 345, 5, 34, 57 },
            };
            myArray[0, 2] = 99;

            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
