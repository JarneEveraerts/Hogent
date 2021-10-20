using System;

namespace getalontleding
{
    class Program
    {
        static void Main(string[] args)
        {
            int Honderd, Tien, Een, Geheel;
            Console.WriteLine("geef een geheel getal(0-999) in");
            Geheel = Convert.ToInt16(Console.ReadLine());
            Honderd = Geheel / 100;
            Geheel = Geheel % 100;
            Tien = Geheel / 10;
            Een = Geheel % 10;
            Console.WriteLine($"{Honderd} X 100");
            Console.WriteLine($"{Tien} X 10");
            Console.WriteLine($"{Een} X 1");

        }
    }
}
