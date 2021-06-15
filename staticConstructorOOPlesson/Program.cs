using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticConstructorOOPlesson
{
    class Program
    {
        class MyClass
        {
            public MyClass()
            {
                Console.WriteLine("Constructor");
            }

            static MyClass()
            {
                Console.WriteLine("Static constructor");
            }
        }

        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            Console.ReadLine();
        }
    }
}
