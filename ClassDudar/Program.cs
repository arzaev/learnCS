using System;

namespace ClassDudar
{
    class Animal
    {
        public string name = "Spotty";
        public int age = 7;
        public float happiness = 0.6f;

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.name = "Tom";
            cat.Print();
            Console.ReadKey();
        }
    }
}
