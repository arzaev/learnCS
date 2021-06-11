using System;
using System.Linq;

namespace conditionNull
{
    class Program
    {

        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            //if (myArray == null)
            //{
            //    Console.WriteLine("sum of elements 0");
            //}
            //else
            //{
            //    Console.WriteLine("Sum of elements " + myArray.Sum());
            //}

            Console.WriteLine("Sum of elements " + myArray?.Sum());

            
        }
    }
}
