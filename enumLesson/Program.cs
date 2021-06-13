using System;

namespace enumLesson
{
    class Program
    {

        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
            {
                return day + 1;
            }
            return DayOfWeek.Monday;

        }

        static void Main(string[] args)
        {
            //while (true)
            //{
            //    ConsoleKey key = Console.ReadKey().Key;

            //    int keyCode = (int)key;

            //    Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

            //    if (key == ConsoleKey.Enter)
            //    {
            //        Console.WriteLine("You typed enter!");
            //    }
            //}

            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek);

            



           

            var values = Enum.GetValues(typeof(DayOfWeek));

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            string str = Console.ReadLine();
            DayOfWeek _dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), str, ignoreCase: true);
            Console.WriteLine(_dayOfWeek);


            Console.ReadLine();


        }
    }
}
