using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// virtual

// override


namespace PolymorphismOOP
{

    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("I am car, I am driving");
        }
    }

    class SportCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("I am driving very fast");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Person person = new Person();
            person.Drive(new SportCar());
            Console.ReadLine();
        }
    }
}
