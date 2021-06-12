using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aggression = 1;

            byte democracyModifier = 2;

            try
            {
                aggression = checked((byte)(aggression - democracyModifier));
                Console.WriteLine(aggression);
            }
            catch (Exception)
            {

                Console.WriteLine("error overflow");
            }
            
        }
    }
}
