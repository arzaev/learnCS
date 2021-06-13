using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{

    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue
    }

    class Point
    {
        public int x;
        public int y;
        public Color color;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            p.x = 4;
            p.y = 2;
            p.color = Color.Orange;

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

            Point p2 = new Point();
            p2.x = 2;
            p2.y = 6;
        }
    }
}
