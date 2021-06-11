using System;

namespace UnitNull
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            //if (str == null)
            //{
            //    Console.WriteLine("str doesn't have data");
            //}
            //else
            //{
            //    Console.WriteLine(str);
            //}

            

            string result = str ?? "str doesn't have data";
            Console.WriteLine(str);
            
        }
    }
}
