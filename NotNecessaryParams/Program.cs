using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotNecessaryParams
{
    class Program
    {

        static int Sum(int a, int b, bool enableLogging = false)
        {

            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("result = " + result);

            }

            return result;

        }

        static void Main(string[] args)
        {

            //Sum(5, 43, true);
            Sum(b: 3, a: 5, enableLogging: true);
            Console.ReadLine();

        }
    }
}
