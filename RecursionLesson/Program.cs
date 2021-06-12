using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionLesson
{
    class Program
    {

        static void Foo(int i)
        {
            Console.WriteLine(i);

            i++;
            Foo(i);

        }

        static void Main(string[] args)
        {
            Foo(0);
        }
    }
}
