using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.CalculatorStrategies;
using CalculatorApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace CalculatorApp.CalculationResultControllers
{
    public class CalculationResultController : ICalculationResultController
    {
        private IDbContext _dbContext;
        private ICalculatorContext _calculatorContext;
        private ICalculatorStrategy _additionStrategy;
        private ICalculatorStrategy _subtractionStrategy;
        private ICalculatorStrategy _multiplicationStrategy;
        private ICalculatorStrategy _divisionStrategy;
        private ICalculatorStrategy _sqrRootStrategy;
        private ICalculatorStrategy _modulusStrategy;
        public CalculationResultController(IDbContext dbContext, ICalculatorContext calculatorContext, ICalculatorStrategy additionStrategy,
            ICalculatorStrategy subtractionStrategy, ICalculatorStrategy multiplicationStrategy, ICalculatorStrategy divisionStrategy,
            ICalculatorStrategy sqrRootStrategy, ICalculatorStrategy modulusStrategy)
        {
            _dbContext = dbContext;
            _calculatorContext = calculatorContext;
            _additionStrategy = additionStrategy;
            _subtractionStrategy = subtractionStrategy;
            _multiplicationStrategy = multiplicationStrategy;
            _divisionStrategy = divisionStrategy;
            _sqrRootStrategy = sqrRootStrategy;
            _modulusStrategy = modulusStrategy;
        }



        public double SetNewCalculationResultStrategyPattern(double num1, double num2, char op)
        {

            switch (op)
            {
                case '+':
                    _calculatorContext.SetStrategy(_additionStrategy);
                    break;
                case '-':
                    _calculatorContext.SetStrategy(_subtractionStrategy);
                    break;
                case '*':
                    _calculatorContext.SetStrategy(_multiplicationStrategy);
                    break;
                case '/':
                    _calculatorContext.SetStrategy(_divisionStrategy);
                    break;
                case '√':
                    _calculatorContext.SetStrategy(_sqrRootStrategy);
                    break;
                case '%':
                    _calculatorContext.SetStrategy(_modulusStrategy);
                    break;

            }

            return _calculatorContext.ExecuteStrategy(num1, num2);


        }



        public CalculationResult ChooseResultToReturn()
        {

            int intSelection;
            Console.WriteLine($"Choose the id of a result to select:");
            while (true)
            {
                Console.WriteLine(">");
                if (int.TryParse(Console.ReadLine(), out intSelection) &&
                    _dbContext.CalculationResults.Any(c => c.Id == intSelection && c.IsActive == true))
                {
                    var calculationResultToReturn = _dbContext.CalculationResults.FirstOrDefault(s => s.Id == intSelection);
                    Console.Clear();
                    return calculationResultToReturn;
                }

                ProgramErrorMessage.ChooseBetweenAvailableMenuNumbers();
            }

        }


  

        public void DisplayChosenResult(CalculationResult calculationResult)
        {
            if (calculationResult.Operator != '√')
            {


                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10}", $"{Environment.NewLine}ID", "x",
                    "op", "y", "=", $"result {Environment.NewLine}");
                Console.WriteLine("{0,-8} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10}",
                    $"{calculationResult.Id}",
                    $"{calculationResult.FirstNumber}",
                    $"{calculationResult.Operator}",
                    $"{calculationResult.SecondNumber}",
                    $"=",
                    $"{calculationResult.EquationResult}");
                Console.WriteLine(
                    $"--------------------------------------------------------------------------------------");
            }

            else
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} ", $"{Environment.NewLine}ID", "op",
                    "x", "=",$"result {Environment.NewLine}");
                Console.WriteLine("{0,-8} {1,-10} {2,-10} {3,-10} {4,-10} ",
                    $"{calculationResult.Id}",
                    $"{calculationResult.Operator}",
                    $"{calculationResult.FirstNumber}",
                    $"=",
                    $"{calculationResult.EquationResult}");
                Console.WriteLine(
                    $"--------------------------------------------------------------------------------------");


            }

        }


    }
}
