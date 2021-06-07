using System;


// && Сокр И
// && || сокр или
// И
// | Или
// ! Не

namespace LogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isHighTemperature = true;
            bool hasNoCooling = true;

            if (isHighTemperature || hasNoCooling)
            {
                Console.WriteLine("It's bad for processor");
            }
        }
    }
}
