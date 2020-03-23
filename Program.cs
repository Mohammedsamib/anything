using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.id = 1200;
            m1.name = "Mohammed";
            m1.address = "Sakarya";
            m1.phone = "05524677219";
            m1.salary = 10090;
            m1.printdata();
            Console.WriteLine("===================");
            Musteri m2 = new Musteri();
            m2.id = 13000;
            m2.name = "Ali";
            m2.address = "Istanbul";
            m2.phone = "05413534543";
            m2.salary = 20000;
            m2.printdata();
            Console.WriteLine("===================");

            Console.ReadKey();
        }
            
    }
}
