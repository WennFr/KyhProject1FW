using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.CalculatorStrategies;

namespace CalculatorApp.CalculatorStrategies
{
    public interface ICalculatorStrategy
    {
        double Execute(double x, double y);
    }
}
