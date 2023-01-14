using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Interfaces;
using CalculatorApp.Menus;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Services;

namespace CalculatorApp.CalculationResultControllers
{
    public class UpdateCalculationResult : IUpdateResult
    {
        private IDbContext _dbContext;
        private IReadResult _readResult;
        private ICalculationResultController _controller;
        public UpdateCalculationResult(IDbContext dbContext, IReadResult readResult, ICalculationResultController controller)
        {
            _dbContext = dbContext;
            _readResult = readResult;
            _controller = controller;
        }

        public void Update()
        {
            while (true)
            {
                Console.Clear();
                MenuHeader.EditResult();

                var isAnyActiveResults = _readResult.Read();

                if (!isAnyActiveResults)
                    break;

                var resultToUpdate = _controller.ChooseResultToReturn();

                var isRunning = true;

                while (isRunning)
                {
                    Console.Clear();
                    _controller.DisplayChosenResult(resultToUpdate);

                    Console.WriteLine($"{Environment.NewLine}What do you want to edit? {Environment.NewLine}");
                    Console.WriteLine("1) First number");
                    Console.WriteLine("2) Operator");
                    Console.WriteLine("3) Second number");
                    Console.WriteLine("0) Save and exit");

                    var userSelection = UserInputService.ValidateMenuSelection(3);
                    var newNumber = 0.00;
                    char op;
                    switch (userSelection)
                    {
                        case 1:
                            Console.Write($"{Environment.NewLine}First number:");
                            newNumber = UserInputService.ValidateDoubleInput();
                            if (MathService.IsInfinity(newNumber) || MathService.IsDividedByZero(newNumber, resultToUpdate.SecondNumber) && resultToUpdate.Operator != '√')
                                continue;

                            resultToUpdate.FirstNumber = newNumber;
                            resultToUpdate.EquationResult = _controller
                                .SetNewCalculationResultStrategyPattern(resultToUpdate.FirstNumber, resultToUpdate.SecondNumber, resultToUpdate.Operator);
                            continue;

                        case 2:
                            Console.Write($"{Environment.NewLine}Enter an Operator: (1.+,2.-,3.*,4./,5.√ or 6.%): ");
                            op = UserInputService.ValidateOperatorSelection();
                            if (resultToUpdate.Operator == '√')
                                resultToUpdate.SecondNumber = 0.00;

                            resultToUpdate.Operator = op;
                            resultToUpdate.EquationResult = _controller
                            .SetNewCalculationResultStrategyPattern(resultToUpdate.FirstNumber, resultToUpdate.SecondNumber, resultToUpdate.Operator);
                            continue;

                        case 3:
                            if (resultToUpdate.Operator == '√')
                                continue;

                            Console.Write($"{Environment.NewLine}Second number:");
                            newNumber = UserInputService.ValidateDoubleInput();
                            if (MathService.IsInfinity(newNumber) || MathService.IsDividedByZero(newNumber, resultToUpdate.SecondNumber) && resultToUpdate.Operator != '√')
                                continue;

                            resultToUpdate.SecondNumber = newNumber;
                            resultToUpdate.EquationResult = _controller
                                .SetNewCalculationResultStrategyPattern(resultToUpdate.FirstNumber, newNumber, resultToUpdate.Operator);
                            continue;

                        case 0:
                            _dbContext.SaveChanges();
                            isRunning = false;
                            break;
                    }


                }

                break;
            }

        }



    }
}
