using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceAccessModifiers
{
    class A
    {
        public int publicField;
        private int privateField;
        protected int protectedField;

        public A()
        {
            Console.WriteLine(publicField);
            Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
        }
    }

    class B : A
    {
        public B()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
