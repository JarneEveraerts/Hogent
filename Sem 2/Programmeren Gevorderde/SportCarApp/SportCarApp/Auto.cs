using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarApp
{
    internal class Auto
    {
        public IDrivingStyle Style { get; set; }

        public Auto(IDrivingStyle style)
        {
            Style = style;
        }

        public void Drive()
        {
            Style.Drive();
        }
    }
}