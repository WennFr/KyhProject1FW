using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace ServiceLibrary.CalculatorStrategies
{
    public class AdditionStrategy : ICalculatorStrategy
    {
        public double Execute(double x, double y)
        {
            return x + y;
        }
    }
}
