﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Interfaces;
using ServiceLibrary.Interfaces;

namespace CalculatorApp.CalculatorStrategies
{
    public class CalculatorContext : ICalculatorContext
    {
        private ICalculatorStrategy _strategy;

        public void SetStrategy(ICalculatorStrategy strategy)
        {
            _strategy = strategy;
        }

        public double ExecuteStrategy(double x, double y)
        {
            return _strategy.Execute(x,y);
        }


    }
}
