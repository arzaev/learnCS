using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumElements
{
    class Program
    {

        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;
            int result = Sum(myArray, i + 1);
            return myArray[i] + result;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 4, 6, 3 };
            int result = Sum(myArray);
        }
    }
}
