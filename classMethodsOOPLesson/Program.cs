using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodsOOPLesson
{
    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();

            student.firstName = "Mac";
            student.middleName = "Foraster";
            student.lastName = "Dugin";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "group1";

            return student;
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            firstStudent.Print();

            var secondStudent = new Student();
            secondStudent.Print();

            Console.ReadLine();

        }
    }
}
