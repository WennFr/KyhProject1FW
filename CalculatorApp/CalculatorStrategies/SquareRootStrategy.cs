using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.CalculatorStrategies
{
    public class SquareRootStrategy : ICalculatorStrategy
    {
        public double Execute(double x, double y)
        {
            return Math.Round(Math.Sqrt(x),2);
        }

    }
}
