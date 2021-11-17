using System;

namespace charcount
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantal = GetCharCount("This is a local shop, for local people; there's nothing for you here..", 'o');
            Console.WriteLine("de letter o komt " + aantal + "keer voor");
        }
        static int GetCharCount(string input,char test)
        {
            int i = 0;
            foreach (char c in input)
            {
                if (c == test)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
