using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumOfNumbersRecursionLesson
{
    class Program
    { 

        static int Foo(int value)
        {
            if (value < 10)
            {
                return value;
            }

            int digit = value % 10;
            
            int nextValue = value / 10;

            return digit + Foo(nextValue);
        }


        static void Main(string[] args)
        {
            int myValue = 561;

            int result = Foo(myValue);
        }
    }
}
