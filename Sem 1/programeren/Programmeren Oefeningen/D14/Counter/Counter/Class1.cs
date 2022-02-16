using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class Counter
    {
        private double _value = 0, _step = 1;

        public void SetValue(double value)
        {
            _value = value;
        }

        public void SetStep(double step)
        {
            _step = step;
        }

        public double GetValue()
        {
            return _value;
        }

        public double Advance()
        {
            this._value = this._value + this._step;
            return this._value;
        }
    }
}