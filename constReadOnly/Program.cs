using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constReadOnly
{
    class Program
    {

        class MyClass
        {
            public const double PI = 3.14;

            public const string MY_ERROR = "some error";

            public readonly int _a;

            public static readonly int _b;

            public MyClass(int a)
            {
                _a = a;
            }

            public void Foo()
            {
                
            }
        }

        static void Main(string[] args)
        {
            MyClass myclass = new MyClass(4);
            myclass.Foo();
        }
    }
}
