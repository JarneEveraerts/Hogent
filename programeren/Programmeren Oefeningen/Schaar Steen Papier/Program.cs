﻿using System;

namespace Schaar_Steen_Papier
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rdm = new Random();
            string Invoer,InvoerPc="";
            //punten variabel
            int Player=0, Pc=0;

            Console.WriteLine("kies BLAD-STEEN-SCHAAR (STOP stopt het spel)");
            Invoer = Console.ReadLine();
            Invoer = Invoer.ToUpper();
            while (Invoer!="STOP")
            {
                if (Invoer=="BLAD" || Invoer=="STEEN" || Invoer=="SCHAAR")
                {
                    //kijken wat de pc gooit
                    switch (Rdm.Next(1,3))
                    {
                        case 1:
                            InvoerPc = "BLAD";
                            break;
                        case 2:
                            InvoerPc = "STEEN";
                            break;
                        case 3:
                            InvoerPc = "SCHAAR";
                            break;
                    }
                    //kijken wie er gewonnen heeft deze ronde
                    switch (Invoer)
                    {
                        case "BLAD":
                            if (InvoerPc == "STEEN")
                            {
                                Player++;
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine($"{Invoer} WINT!!!");
                            }
                            else if (InvoerPc == "SCHAAR")
                            {
                                Pc++;
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine($"{InvoerPc} WINT!!!");
                            }
                            else
                            {
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine("ITS A DRAW");
                            }
                            Console.WriteLine("kies BLAD-STEEN-SCHAAR (STOP stopt het spel)");
                            Invoer = Console.ReadLine();
                            Invoer = Invoer.ToUpper();
                            break;
                        case "STEEN":
                            if (InvoerPc == "SCHAAR")
                            {
                                Player++;
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine($"{Invoer} WINT!!!");
                            }
                            else if (InvoerPc == "BLAD")
                            {
                                Pc++;
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine($"{InvoerPc} WINT!!!");
                            }
                            else
                            {
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine("ITS A DRAW");
                            }
                            Console.WriteLine("kies BLAD-STEEN-SCHAAR (STOP stopt het spel)");
                            Invoer = Console.ReadLine();
                            Invoer = Invoer.ToUpper();
                            break;
                        case "SCHAAR":
                            if (InvoerPc == "BLAD")
                            {
                                Player++;
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine($"{Invoer} WINT!!!");
                            }
                            else if (InvoerPc == "STEEN")
                            {
                                Pc++;
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine($"{InvoerPc} WINT!!!");
                            }
                            else
                            {
                                Console.WriteLine($"{Invoer} VS {InvoerPc}");
                                Console.WriteLine("ITS A DRAW");
                            }
                            Console.WriteLine("kies BLAD-STEEN-SCHAAR (STOP stopt het spel)");
                            Invoer = Console.ReadLine();
                            Invoer = Invoer.ToUpper();
                            break;
                    }
                    

                }
                else
                {
                    Console.WriteLine("gelieve een geldige ingave te geven BLAD-STEEN-SCHAAR(STOP om af te sluiten)");
                    Invoer = Console.ReadLine();
                    Invoer = Invoer.ToUpper();
                }
            }
            //kijken wie er gewonnen heeft
            Console.Clear();
            Console.WriteLine("HERE ARE THE POINTS");
            Console.WriteLine($"PLAYER: {Player}");
            Console.WriteLine($"PC: {Pc}");
            if (Player < Pc)
            {
                Console.WriteLine("PC IS THE WINNER");
            }
            else if (Player > Pc)
            {
                Console.WriteLine("PLAYER IS THE WINNER");
            }
            else
            {
                Console.WriteLine("ITS A DRAW");
            }
            
            
        }
    }
}
