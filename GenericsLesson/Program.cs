using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = CreateArray<int>(4, 6);
            TestMultiplyGenerics<int, string>(56, "asdf");
        }

        private static T[] CreateArray<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }

        private static void TestMultiplyGenerics<T1, T2>(T1 t1, T2 t2)
        {

        }

    }
        
}
