using System;

namespace HomeWorkResize
{
    class Program
    {

        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6 };
            string[] strArray = { "hello", "dfg", "fdsg"};

            //Array.Resize(ref myArray, 10);

            Resize(ref myArray, 10);
        }
    }
}
