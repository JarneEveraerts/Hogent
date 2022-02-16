using System;

namespace D06.sommeer1tem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int kwadraat;
            for (int i = 0; i < 11; i++)
            {
                kwadraat = i * i;
                som += kwadraat;
            }

            Console.WriteLine(som);

            Console.ReadKey();
        }
    }
}
