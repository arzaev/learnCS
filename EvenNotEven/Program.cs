using System;

namespace EvenNotEven
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int currentValue = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                }
                else
                {
                    oddNumbersCount++;
                }
                currentValue++;
            }
            Console.WriteLine("Odd: " + oddNumbersCount);
            Console.WriteLine("Even: " + evenNumbersCount);
            Console.WriteLine("Number of numbers: " + currentValue);
        }
    }
}
