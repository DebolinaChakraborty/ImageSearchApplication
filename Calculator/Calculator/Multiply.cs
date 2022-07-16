using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Multiply : IOperate
    {
        public double PerformOperation(double x, double y)
        {
            return x*y;
        }
    }
}
