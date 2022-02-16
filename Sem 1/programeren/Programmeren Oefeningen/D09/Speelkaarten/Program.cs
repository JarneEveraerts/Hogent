using System;

namespace Speelkaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] Waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "landbouwer", "dame", "koning", "aas" };
            string[] Gelegd = new string[51];
            bool Checked = false;
            int CardCount = 0, CheckCount = 0,Value=0,Icon=0;
            string NewCard = "";
            Random rnd = new Random();
            Value = rnd.Next(0, 12);
            Icon = rnd.Next(0, 3);
            NewCard = Icon.ToString() + Value.ToString();
            while (CardCount<52)
            {
                foreach(string Check in Gelegd)
                {
                    if (NewCard==Check)
                    {
                        Checked = true;
                    }
                }
                if (Checked==false)
                {
                    Gelegd[CheckCount] = NewCard;
                    CheckCount++;
                    Console.WriteLine($"{Kleuren[Icon]} {Waarden[Value]}");
                    Value = rnd.Next(0, 12);
                    Icon = rnd.Next(0, 3);
                    NewCard = Icon.ToString() + Value.ToString();
                    CardCount++;
                }
                else
                {
                    Value = rnd.Next(0, 12);
                    Icon = rnd.Next(0, 3);
                    NewCard = Icon.ToString() + Value.ToString();
                    Checked = false;
                }
            }     

        }
    }
}
