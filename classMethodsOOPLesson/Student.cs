using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodsOOPLesson
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Information about student");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Surname: {lastName}");
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Middle name: {middleName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }
    }
}
