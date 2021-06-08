using System;

namespace HomeWorkArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEvenNumbers = 0;
            int minNumber = 0;
            int[] myArray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Type some number: ");
                int bar = int.Parse(Console.ReadLine());
                myArray[i] = bar;
            }

            Console.Write("\nYou result: ");


            minNumber = myArray[myArray.Length - 1];
            for (int j = myArray.Length - 1; j >= 0; j--)
            {
                int currentNumber = myArray[j];
                Console.Write(currentNumber + " ");


                if (currentNumber % 2 == 0)
                {
                    sumEvenNumbers += currentNumber;
                }

                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine();

            Console.WriteLine("sum even number: " + sumEvenNumbers);
            Console.WriteLine("min number: " + minNumber);
        }
    }
}
