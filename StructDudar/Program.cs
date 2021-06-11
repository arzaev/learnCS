using System;

namespace StructDudar
{
    struct Book
    {
        public string title;
        public string name;
        public string author;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book b;
            b.title = "King";

            Console.ReadLine();
        }
    }
}
