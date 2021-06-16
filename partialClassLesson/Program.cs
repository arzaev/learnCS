using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClassLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "al");
            person.PrintFullName();
            Console.ReadLine();
        }
    }
}
