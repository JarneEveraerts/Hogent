using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afstandtussenpunten
{
    internal class Punt
    {
        private double _x;
        private double _y;

        public void SetPunt(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public string GetPunt()
        {
            string output = (_x + "," + _y);
            return output;
        }

        public double GetAfstandTussen(string punt1, string punt2)
        {
            double x1, x2, y1, y2;
            string[] punt1Split = punt1.Split(",");
            string[] punt2Split = punt2.Split(",");

            x1 = double.Parse(punt1Split[0]);
            x2 = double.Parse(punt2Split[0]);
            y1 = double.Parse(punt1Split[1]);
            y2 = double.Parse(punt2Split[1]);

            double output = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return output;
        }
    }
}