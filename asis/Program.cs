using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asis
{
    class Point : Object
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine("X: " + X);
            Console.WriteLine("Y: " + Y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new Point { X = 3, Y = 5 };
            //Foo(obj);
            Bar(obj);
        }

        static void Foo(object obj)
        {
            Point point = obj as Point;

            if(point != null)
            {
                point.Print();
            }
        }

        static void Bar(object obj)
        {
            if (obj is Point point)
            {
                point.Print();
            }
        }
    }
}
