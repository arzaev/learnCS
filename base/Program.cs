using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass");
        }
    }


    class Point2D : MyClass
    {

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("construcotr 2D");
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Print2D()
        {
            Console.WriteLine("X: " + X);
            Console.WriteLine("Y: " + Y);
        }
    }

    class Point3D : Point2D
    {

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("construcotr 3D");
        }

        public int Z { get; set; }

        public void Print3D()
        {
            base.Print2D();
            Console.WriteLine("Z: " + Z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D(3, 5, 6);
            point3D.Print3D();
            Console.ReadLine();
        }
    }
}
