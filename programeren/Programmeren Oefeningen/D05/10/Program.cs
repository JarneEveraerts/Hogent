using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, Zijde;
            string Z="";
            Console.Write("Rechthoekzijde?: ");
            Zijde = int.Parse(Console.ReadLine());
            do
            {
                while (i<Zijde)
                {
                    Z +="*";
                    i++;
                }
                Console.WriteLine(Z);
                Zijde--;
                i = 0;
                Z = "";
            } while (Zijde>0);
        }
    }
}
