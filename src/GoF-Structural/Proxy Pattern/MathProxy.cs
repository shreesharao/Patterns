using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class MathProxy : IMath
    {
        private readonly Math _math = new Math();
        public double Add(double x, double y)
        {
            //just as an example Proxy can implement additional checks before caling the real object
            if (x != 0 && y != 0)
            {
                return _math.Add(x, y);
            }
            throw new ArgumentNullException("Input is not proper");
    
        }

        public double Divide(double x, double y)
        {
            return _math.Divide(x, y);
        }

        public double Multiply(double x, double y)
        {
            return _math.Multiply(x, y);
        }

        public double Substract(double x, double y)
        {
            return _math.Substract(x, y);
        }
    }
}
