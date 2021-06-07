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

            int fanSpeed = 3000;

            bool isHighTemperature = true;
            bool hasNoCooling = fanSpeed <= 0;

            if (isHighTemperature || hasNoCooling)
            {
                Console.WriteLine("It's bad for processor");
            }
        }
    }
}
