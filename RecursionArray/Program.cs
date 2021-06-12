using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionArray
{
    class Program
    {

        static void PrinArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrinArray(myArray, i + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = { 5, 4, 2 };

            PrinArray(myArray);

        }
    }
}
