using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOPlesson
{

    class Person
    {
        public int a;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"My name is {FirstName}!");
        }
    }

    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine("I am learning!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { FirstName = "Mike", LastName = "Fox" };
            student.PrintName();
            student.Learn();

            Console.ReadLine();
        }
    }
}
