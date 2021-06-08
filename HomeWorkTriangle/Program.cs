using System;


namespace HomeWorkTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("height: ");
            //int height = int.Parse(Console.ReadLine());

            //Console.WriteLine("width: ");
            //int width = int.Parse(Console.ReadLine());

            int count = 0;
            for (int j = 0; j <= 10; j++)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                count++;
            }

            Console.WriteLine("\n");

            count = 0;
            for (int bar = 0; bar <= 10; bar++)
            {
                for (int i = 10; i > count; i--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                count++;
            }

            count = 0;
            int countIns = 0;
            for (int foo = 0; foo <= 10; foo++)
            {
                for (int m = 10; m > countIns; m--)
                {
                    Console.Write(" ");
                }
                countIns++;

                for (int i = 0; i < count; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                count++;
            }

            Console.WriteLine("\n");
            count = 0;
            countIns = 0;
            for (int foo = 0; foo <= 10; foo++)
            {
                for (int m = 0; m < countIns; m++)
                {
                    Console.Write(" ");
                }
                countIns++;

                for (int i = 10; i > count; i--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                count++;
            }





            Console.ReadLine();
        }
    }
}
