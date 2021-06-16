using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitObjects
{
    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Cat()
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Age = 3;
            cat1.Name = "Tom";

            Cat cat2 = new Cat
            {
                Age = 4,
                Name = "Tom"
            };
        }
    }
}
