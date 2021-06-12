using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// implicit

namespace ConversionTypeLesson
{
    class Program
    {

        static void Foo(float value)
        {
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            double a = 5.3;

            // явное преобразование
            float b = (float)a;

            // неявное преобразование
            //float b = a;

        }
    }
}
