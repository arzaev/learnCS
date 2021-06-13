using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            //int a = null;
            DateTime? dateTime = null;

            int? i = null;

            Console.WriteLine(i == null); //True

            Console.WriteLine(i.HasValue); //False

            Console.WriteLine(i.GetValueOrDefault()); // 0

            Console.WriteLine(i.GetValueOrDefault(3)); // 3

            Console.WriteLine(i ?? 55); //5

            Console.WriteLine(i.Value); //InvalidOperationException

        }
    }
}
