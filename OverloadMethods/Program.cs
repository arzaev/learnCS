using System;

namespace OverloadMethods
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

        static double Sum(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int result = Sum(2, 3, 4);
            double resultDouble = Sum(3.5, 3.4);
            Console.WriteLine(result);
            Console.WriteLine(resultDouble);
        }
    }
}
