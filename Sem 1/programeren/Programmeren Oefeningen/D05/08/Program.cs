using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string BreedteString="";
            int H = 0;
            Console.Write("Hoogte?: ");
            int Hoogte = int.Parse(Console.ReadLine());

            Console.Write("Breedte?: ");
            int Breedte = int.Parse(Console.ReadLine());
            int B = 0;
            do
            {
                BreedteString += "*";
                B++; ;
            } while (B < Breedte);
            do
            {
                H++;
                Console.WriteLine(BreedteString);
            } while (H<Hoogte);
        }
    }
}
