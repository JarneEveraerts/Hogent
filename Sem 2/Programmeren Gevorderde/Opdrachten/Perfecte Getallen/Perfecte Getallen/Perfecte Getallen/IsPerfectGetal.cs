using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfecte_Getallen
{
    internal class PerfectGetal
    {
        public static bool IsPerfectGetal(int? input)
        {
            if (input == null)
            {
                throw new ArgumentException("Ongeldige tekst");
            }
            if (input < 0)
            {
                throw new ArgumentException("het getal kan niet negatief zijn");
            }
            if (input < 2)
            {
                throw new ArgumentException("het getal kan niet 0 of 1 zijn");
            }

            int i = 1;
            int total = 0;

            for (i = 1; i < input; i++)
            {
                if (input % i == 0)
                    total += i;
            }

            return total == input;
        }
    }
}