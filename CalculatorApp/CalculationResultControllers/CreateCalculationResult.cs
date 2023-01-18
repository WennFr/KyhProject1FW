using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.CalculatorStrategies;
using Microsoft.EntityFrameworkCore;
using CalculatorApp.CalculatorStrategies;
using CalculatorApp.Interfaces;
using CalculatorApp.Menus;
using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace CalculatorApp.CalculationResultControllers
{
    public class CreateCalculationResult : ICreateResult
    {
        private IDbContext _dbContext;
        private ICalculationResultController _controller;
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
                CalcMenuHeader.CreateCalculation();
                double num1, num2 = 0.00;
                double result = 0.00;
                char op;

                ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}First Number:");
                num1 = UserInputService.ValidateDoubleInput();

                if (MathErrorExceptionService.IsInfinity(num1))
                    continue;

                Console.Clear();
                CalcMenuHeader.CreateCalculation();

                Console.WriteLine($"{Environment.NewLine}{num1}");

                CalculatorSubMenu.DisplayAvailableOperatorsSelection();

                op = UserInputService.ValidateOperatorSelection();

                if (op != '√')
                {
                    Console.Clear();
                    CalcMenuHeader.CreateCalculation();
                    Console.WriteLine($"{Environment.NewLine}{num1} {op}");

                    ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Second Number: ");
                    num2 = UserInputService.ValidateDoubleInput();

                    if (MathErrorExceptionService.IsInfinity(num2))
                        continue;
                    if (MathErrorExceptionService.IsDividedByZero(num1, num2, op))
                        continue;
                }

                else if (op == '√')
                    if (MathErrorExceptionService.IsSquareRootOfNegativeNumber(num1, op))
                        continue;

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

                ServiceMessage.Sucess();

                ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Create new calculation?(y/n)");
                var isNewCalculation = UserInputService.ValidateTrueOrFalseUserChoice();
                if (!isNewCalculation)
                    break;
            }

        }



    }



}
