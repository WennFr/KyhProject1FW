using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace CalculatorApp.CalculationResultControllers
{
    public class ReadCalculationResult : IReadResult
    {
        private IDbContext _dbContext;
        public ReadCalculationResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Read()
        {

            if (_dbContext.CalculationResults.Count() < 0 || !_dbContext.CalculationResults.Any(c => c.IsActive == true))
            {
                ProgramErrorMessage.NoActiveResultsToView();
                return false;
            }

            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10}", $"{Environment.NewLine}ID", "x", "op", "y", "=", $"result {Environment.NewLine}");
            foreach (var calculationResult in _dbContext.CalculationResults.Where(c => c.IsActive == true))
            {
                var stringTColor = String.Format("{0,-8} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10}",
                     $"{calculationResult.Id}",
                     $"{calculationResult.FirstNumber}",
                     $"{calculationResult.Operator}",
                     $"{calculationResult.SecondNumber}",
                     $"=",
                     $"{calculationResult.EquationResult}");
                
                ColorService.ConsoleWriteLineYellow(stringTColor);
                Console.WriteLine(
                    $"--------------------------------------------------------------------------------------");
            }

            return true;
        }


    }
}
