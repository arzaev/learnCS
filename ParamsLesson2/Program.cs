using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsLesson2
{
    class Program
    {
        static void Foo(params object[] parameters)
        {
            string message = "Type data {0}, item {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            Foo("hello", 5, "No", 4.5, true);

            Console.ReadLine();
        }
    }
}
