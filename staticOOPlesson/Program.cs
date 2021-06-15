using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticOOPlesson
{
    class Program
    {
        class MyClass2
        {
            public MyClass2()
            {
                Counter++;
            }

            private static int counter;

            public static int Counter
            {
                get { return counter; }
                private set { counter = value; }
            }
            public static int GetCounter()
            {
                return counter;
            }

            public int GetObjectsCount()
            {
                return counter;
            }

        }

        class MyClass
        {
            public int a;

            public static int b;
            public static void Foo()
            {
                Console.WriteLine("Foo");
            }

            public void Bar()
            {
                Console.WriteLine("Bar");
            }
        }

        static void Main(string[] args)
        {
            MyClass.b = 5;

            MyClass myClass1 = new MyClass();
            myClass1.a = 44;

            MyClass myClass2 = new MyClass();
            myClass2.a = 22;

            MyClass2 myClassSt1 = new MyClass2();
            Console.WriteLine(myClassSt1.GetObjectsCount());
            MyClass2 myClassSt2 = new MyClass2();
            MyClass2 myClassSt3 = new MyClass2();
            Console.WriteLine(myClassSt1.GetObjectsCount());
            Console.WriteLine(MyClass2.Counter);

            Console.ReadLine();
        }
    }
}
