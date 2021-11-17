using System;

namespace geenscheldwoordarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst : ");
            string tekst = Console.ReadLine();

            bool isOk = IsAanvaardbaar(tekst);

            if (isOk)
            {
                Console.WriteLine("Tekst is aanvaardbaar");
            }
            else
            {
                Console.WriteLine("Tekst is niet aanvaardbaar");
            }
        }
        static bool IsAanvaardbaar(string woord)
        {
            bool isOk=true;
            switch (woord.Trim().ToLower())
            {
                case "fuck":
                    isOk = false;
                    break;
                case"penis":
                    isOk = false;
                    break;
                case "kut":
                    isOk = false;
                    break;
            }
            return isOk;
        }
    }
}
