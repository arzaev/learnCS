using System;

namespace ThreeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[4, 3, 5];

            //{
            //    {
            //        {3, 35, 2 },
            //        {3, 35, 2 }
            //    },
            //    {
            //        {45, 54, 76 },
            //        {36, 3655, 562 }
            //    },
            //    {
            //        {673, 345, 27 },
            //        {36, 355, 23 }
            //    },
            //};

            Random random = new Random();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    for (int z = 0; z < myArray.GetLength(2); z++)
                    {
                        myArray[y, x, z] = random.Next(100);
                    }
                }
            }

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                Console.WriteLine("page no: " + (y + 1));
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    for (int z = 0; z < myArray.GetLength(2); z++)
                    {
                        Console.Write(myArray[y, x, z] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
