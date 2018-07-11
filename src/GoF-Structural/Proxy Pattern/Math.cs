using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class Math : IMath
    {
        public double Add(double x, double y) => x + y;
        public double Substract(double x, double y) =>  x - y;
        public double Multiply(double x, double y) => x * y;
        public double Divide(double x, double y) => x / y;

    }
}
