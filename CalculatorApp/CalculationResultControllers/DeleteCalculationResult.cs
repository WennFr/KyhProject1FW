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
    public class DeleteCalculationResult : IDeleteResult
    {
        private IDbContext _dbContext;
        private IReadResult _readResult;
        private ICalculationResultController _controller;
        public DeleteCalculationResult(IDbContext dbContext,IReadResult readResult ,ICalculationResultController controller)
        {
            _dbContext = dbContext;
            _readResult = readResult;
            _controller = controller;
        }


        public void Delete()
        {

            while (true)
            {
                Console.Clear();
                CalcMenuHeader.DeleteResult();

                var isAnyActiveResults = _readResult.Read();
                if (!isAnyActiveResults)
                    break;

                var resultToDelete = _controller.ChooseResultToReturn();

                Console.WriteLine($"{Environment.NewLine}Are you sure you want to delete this result? y/n");
                var isDeleteResult = UserInputService.ValidateTrueOrFalseUserChoice();
                if (!isDeleteResult)
                {
                    Console.WriteLine("Process cancelled.");
                    ServiceMessage.PressEnterToContinue();
                    break;

                }

                resultToDelete.IsActive = false;
                _dbContext.SaveChanges();

                Console.Clear();
                Console.WriteLine("Result was deleted.");
                ServiceMessage.PressEnterToContinue();
                break;

            }

        }


    }
}
