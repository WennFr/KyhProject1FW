using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.CalculatorStrategies;

namespace CalculatorApp.CalculatorStrategies
{
    public interface ICalculatorContext
    {

        public void SetStrategy(ICalculatorStrategy strategy);
        public double ExecuteStrategy(double x, double y);

    }
}
