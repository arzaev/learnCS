using System;

namespace HomeWorkMethods
{
    class Program
    {

        static string multString(string str, int mult)
        {
            string bar = "";
            for (int i = 0; i < mult; i++)
            {
                bar += str;
            }
            return bar;
        }

        static int firstIndex(int[] myArray)
        {
            if (myArray.Length != 0)
            {
                return myArray[0];
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Type string: ");
            string str = Console.ReadLine();
            Console.WriteLine("How many times do you want to print your string?: ");
            int times = int.Parse(Console.ReadLine());
            string result = multString(str, times);
            Console.WriteLine(result);

            int[] myArray = { 34, 46, 23, 12, 54, 3 };
            int resultIndex = firstIndex(myArray);
            Console.WriteLine(resultIndex);
        }
    }
}
