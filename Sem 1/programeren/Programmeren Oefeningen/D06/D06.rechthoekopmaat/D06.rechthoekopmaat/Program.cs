using System;

namespace D06.rechthoekopmaat
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoogte = 0;
            int breedte = 0;

            string hoogteString;
            string breedteString;

            bool loop = true;


            while (loop != false)
            {
                Console.Write("breedte: ");
                breedteString = Console.ReadLine();

                Console.Write("hoogte: ");
                hoogteString = Console.ReadLine();

                if (string.IsNullOrEmpty(hoogteString))
                {
                    hoogte = 0;
                }
                else
                {
                    hoogte = Convert.ToInt32(hoogteString);
                }

                if (string.IsNullOrEmpty(breedteString))
                {
                    breedte = 0;
                }
                else
                {
                    breedte = Convert.ToInt32(breedteString);
                }


                if (hoogte <= 0 || breedte <= 0)
                {
                    loop = true;
                    Console.Clear();
                }
                else
                {
                    loop = false;
                }

            }

            int tellerHoogte = 0;
            do
            {
                int tellerBreedte = 0;
                do
                {
                    Console.Write("*");
                    tellerBreedte += 1;
                } while (tellerBreedte < breedte);
                Console.WriteLine();
                tellerHoogte += 1;
            } while (tellerHoogte < hoogte);

            Console.ReadKey();
        }
    }
}
