using System;

namespace ArrayLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 4, 6, 3, 55 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
