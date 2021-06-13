using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 344, 40, 1234, 34, 3, 25, 3 };

            var result = from i in numbers where i > 15 select i;

            foreach (var item in result)
            {
                Console.WriteLine($"{item}\t");

                Console.WriteLine();

                Console.WriteLine($"Data type result {result.GetType()}");
            }

        }
    }
}
