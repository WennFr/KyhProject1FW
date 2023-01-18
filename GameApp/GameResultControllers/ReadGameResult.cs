using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace GameApp.GameResultControllers
{
    public class ReadGameResult : IReadResult
    {
        private IDbContext _dbContext;
        public ReadGameResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Read()
        {

            if (_dbContext.GameResults.Count() < 0 || !_dbContext.GameResults.Any(g => g.IsActive == true))
            {
                ProgramErrorMessage.NoActiveResultsToView();
                return false;
            }

            Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-10} {4,-20} {5,-10}", $"{Environment.NewLine}ID", "PlayerWins", "ComputerWins", "Rounds", "AvgPlayerWins%", $"Date {Environment.NewLine}");
            foreach (var gameResult in _dbContext.GameResults.Where(g => g.IsActive == true))
            {
               var stringToColor = String.Format("{0,-8} {1,-15} {2,-15} {3,-10} {4,-20} {5,-10}",
                    $"{gameResult.Id}",
                    $"{gameResult.NumberOfPlayerWins}",
                    $"{gameResult.NumberOfComputerWins}",
                    $"{gameResult.AmountOfRounds}",
                    $"{gameResult.AveragePlayerWinsPercentage}%",
                    $"{gameResult.DateOfGameResult}");

               ColorService.ConsoleWriteLineYellow(stringToColor);
                Console.WriteLine(
                    $"-------------------------------------------------------------------------------------------------");
            }

            return true;


        }



    }
}
