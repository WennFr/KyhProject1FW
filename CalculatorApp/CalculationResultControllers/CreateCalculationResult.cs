using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.CalculatorStrategies;
using Microsoft.EntityFrameworkCore;
using CalculatorApp.CalculatorStrategies;
using CalculatorApp.Interfaces;
using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Services;

namespace CalculatorApp.CalculationResultControllers
{
    public class CreateCalculationResult : ICreateResult
    {
        private IDbContext _dbContext;
        private ICalculationResultController _controller;
        //private ICalculatorStrategy _additionStrategy;
        //private ICalculatorStrategy _subtractionStrategy;
        //private ICalculatorStrategy _multiplicationStrategy;
        //private ICalculatorStrategy _divisionStrategy;
        //private ICalculatorStrategy _sqrRootStrategy;
        //private ICalculatorStrategy _modulusStrategy;
        public CreateCalculationResult(IDbContext dbContext, ICalculationResultController controller)
        {
            _dbContext = dbContext;
            _controller = controller;
        }

        public void Create()
        {
            while (true)
            {
                Console.Clear();
                double num1, num2 = 0.00;
                double result = 0.00;
                char op;
                try
                {
                    Console.Write("Enter your First Number:  ");
                    num1 = UserInputService.ValidateDoubleInput();

                    if (MathService.IsInfinity(num1))
                        continue;

                    Console.Clear();
                    Console.WriteLine($"{num1}");

                    Console.Write($"{Environment.NewLine}Enter an Operator: (1.+,2.-,3.*,4./,5.√ or 6.%): ");
                    op = UserInputService.ValidateOperatorSelection();

                    if (op != '√')
                    {

                        Console.Clear();
                        Console.WriteLine($"{num1} {op}");

                        Console.Write($"{Environment.NewLine}Enter your Second Number: ");
                        num2 = UserInputService.ValidateDoubleInput();

                        if (MathService.IsInfinity(num2))
                            continue;
                        if (MathService.IsDividedByZero(num1, num2))
                            continue;
                    }

                    else if (op == '√')
                        if (MathService.IsSquareRootOfNegativeNumber(num1))
                            continue;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.ReadKey();
                    continue;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.ReadKey();
                    continue;
                }

                result = _controller.SetNewCalculationResultStrategyPattern(num1, num2, op);

                Console.Clear();

                if (op == '√')
                    Console.WriteLine($"{op}{num1} = {result}");
                else
                    Console.WriteLine($"{num1} {op} {num2} = {result}");


                _dbContext.CalculationResults.Add(new CalculationResult()
                {
                    FirstNumber = num1,
                    Operator = op,
                    SecondNumber = num2,
                    EquationResult = result,
                    DateOfCalculation = DateTime.Now,
                    IsActive = true
                });

                _dbContext.SaveChanges();

                Console.WriteLine($"{Environment.NewLine}Create new calculation?(y/n)");
                var isNewCalculation = UserInputService.ValidateTrueOrFalseUserChoice();
                if (!isNewCalculation)
                    break;
            }

        }



    }



}
