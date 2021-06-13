using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{

    class Point
    {
        int z = 3; // <--default private
        public int x = 3;
        private int y = 5;

        private void PrintX()
        {
            Console.WriteLine($"X {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.PrintPoint();

            Console.ReadLine();
        }
    }
}
