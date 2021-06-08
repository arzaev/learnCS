using System;

namespace Ternarn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;
            string storedPassword = "qwrty";
            string enteredPassword = Console.ReadLine();

            accessAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);

            int inputData = int.Parse(Console.ReadLine());

            int outputData = inputData < 0 ? 0 : inputData;

            Console.ReadLine();
        }
    }
}
