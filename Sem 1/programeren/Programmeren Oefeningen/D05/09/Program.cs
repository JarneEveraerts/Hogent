using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            string BreedteString = "";
            int H = 0;
            Console.Write("Invoer?: ");
            int Ingave = int.Parse(Console.ReadLine());

            int B = 0;
            do
            {
                BreedteString += "*";
                B++; ;
            } while (B < Ingave);
            do
            {
                H++;
                Console.WriteLine(BreedteString);
            } while (H < Ingave);
        }
    }
}
