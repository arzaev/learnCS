using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisOOPlesson
{

    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName, birthday)
        {
            this.firstName = firstName;
            this.middleName = middleName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;

        public void Print()
        {
            Console.WriteLine($"Name: {firstName}\nSirname: {lastName}\nMiddle name: {middleName}\nDate of birthday: {birthday}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mike", new DateTime(2000, 10, 5));
            student1.Print();

            Console.ReadLine();
        }
    }
}
