using System;


// Массив - совокупность элементов одного типа

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5];

            myArray[1] = 3;

            Console.WriteLine(myArray[1]);

            Console.ReadLine();
        }
    }
}
