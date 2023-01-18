using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Interfaces;
using CalculatorApp.Menus;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
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
                CalcMenuHeader.EditResult();

                var isAnyActiveResults = _readResult.Read();

                if (!isAnyActiveResults)
                {
                    ServiceMessage.PressEnterToContinue();
                    break;
                }

                var resultToUpdate = _controller.ChooseResultToReturn();

                var isRunning = true;

                while (isRunning)
                {
                    Console.Clear();
                    _controller.DisplayChosenResult(resultToUpdate);
                    
                    if (resultToUpdate.Operator == '√')
                    CalculatorSubMenu.DisplayUpdateCalculatorSelectionOneNumber();
                    else
                    CalculatorSubMenu.DisplayUpdateCalculatorSelectionTwoNumbers();

                    var userSelection = UserInputService.ValidateMenuSelection(3);
                    var newNumber = 0.00;
                    char op;
                    switch (userSelection)
                    {
                        case 1:
                            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}First number:");
                            newNumber = UserInputService.ValidateDoubleInput();
                            if (MathErrorExceptionService.IsInfinity(newNumber) || MathErrorExceptionService.IsDividedByZero(newNumber, resultToUpdate.SecondNumber, resultToUpdate.Operator)
                                                                  || MathErrorExceptionService.IsSquareRootOfNegativeNumber(newNumber, resultToUpdate.Operator))
                                continue;

                            resultToUpdate.FirstNumber = newNumber;
                            resultToUpdate.EquationResult = _controller
                                .SetNewCalculationResultStrategyPattern(resultToUpdate.FirstNumber, resultToUpdate.SecondNumber, resultToUpdate.Operator);
                            continue;

                        case 2:
                            CalculatorSubMenu.DisplayAvailableOperatorsSelection();
                            op = UserInputService.ValidateOperatorSelection();
                            if (resultToUpdate.Operator == '√')
                                resultToUpdate.SecondNumber = 1.00;

                            if (MathErrorExceptionService.IsDividedByZero(resultToUpdate.FirstNumber, resultToUpdate.SecondNumber, op)
                                || MathErrorExceptionService.IsSquareRootOfNegativeNumber(resultToUpdate.FirstNumber, op))
                                continue;

                            resultToUpdate.Operator = op;
                            resultToUpdate.EquationResult = _controller
                            .SetNewCalculationResultStrategyPattern(resultToUpdate.FirstNumber, resultToUpdate.SecondNumber, resultToUpdate.Operator);
                            continue;

                        case 3:
                            if (resultToUpdate.Operator == '√')
                                continue;

                            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Second number:");
                            newNumber = UserInputService.ValidateDoubleInput();
                            if (MathErrorExceptionService.IsInfinity(newNumber) || MathErrorExceptionService.IsDividedByZero(resultToUpdate.FirstNumber, newNumber, resultToUpdate.Operator))
                                continue;

                            resultToUpdate.SecondNumber = newNumber;
                            resultToUpdate.EquationResult = _controller
                                .SetNewCalculationResultStrategyPattern(resultToUpdate.FirstNumber, newNumber, resultToUpdate.Operator);
                            continue;

                        case 0:
                            if (resultToUpdate.Operator == '√')
                                resultToUpdate.SecondNumber = 0.00;

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
