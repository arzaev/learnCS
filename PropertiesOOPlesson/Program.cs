using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// propfull

namespace PropertiesOOPlesson
{

    class Point
    {
        private int x;

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return x;
        }

        private int y;

        public int Y
        {
            get 
            { 
                return y; 
            }
            set 
            { 
                y = value; 
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            point.Y = 10;

            int y = point.Y;


        }
    }
}
