using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethodsOOPlesson
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();

            if (currentDateTime.IsDayOfWeek(DayOfWeek.Sunday))
            {

            }
            else
            {

            }
        }
    }
}
