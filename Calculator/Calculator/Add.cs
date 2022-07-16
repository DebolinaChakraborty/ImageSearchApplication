using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Add : IOperate
    {
        public double PerformOperation(double x, double y)
        {
            return x + y;
        }
    }
}
