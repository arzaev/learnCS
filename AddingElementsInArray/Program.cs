using System;

namespace AddingElementsInArray
{
    class Program
    {

        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
