using System;

namespace JoinUnitNull
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
            string str = null;
            string result = str ??= "default string";

            Console.WriteLine(result);


            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine(myArray.Length);
        }
    }
}
