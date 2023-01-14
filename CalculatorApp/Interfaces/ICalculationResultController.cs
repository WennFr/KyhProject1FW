using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Data;

namespace CalculatorApp.Interfaces
{
    public interface ICalculationResultController
    {
        CalculationResult ChooseResultToReturn();

        void DisplayChosenResult(CalculationResult result);

        double SetNewCalculationResultStrategyPattern(double num1, double num2, char op);


    }
}
