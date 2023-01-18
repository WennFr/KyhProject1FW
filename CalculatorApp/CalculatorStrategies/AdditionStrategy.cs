using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Interfaces;
using ServiceLibrary.Interfaces;

namespace CalculatorApp.CalculatorStrategies
{
    public class AdditionStrategy : ICalculatorStrategy
    {
        public double Execute(double x, double y)
        {
            return Math.Round(x + y,2);
        }
    }
}
