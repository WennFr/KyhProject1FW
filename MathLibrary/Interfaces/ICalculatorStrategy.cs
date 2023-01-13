using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Interfaces
{
    public interface ICalculatorStrategy
    {
        double Execute(double x, double y);
    }
}
