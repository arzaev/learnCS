using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsLesson
{
    class Program
    {

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Sum(string str, params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
                Console.WriteLine(str);
            }
            return result;
        }


        static void Main(string[] args)
        {
            int result = Sum("hello", 5, 10, 3);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
