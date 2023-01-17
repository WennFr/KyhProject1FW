using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;

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

            if (_dbContext.GameResults.Count() < 0 || !_dbContext.GameResults.Any(c => c.IsActive == true))
            {
                ProgramErrorMessage.NoActiveResultsToView();
                ServiceMessage.PressEnterToContinue();
                return false;
            }

            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10}", $"{Environment.NewLine}ID", "PlayerWins", "ComputerWins", "Rounds", "AvgPlayerWins", $"Date {Environment.NewLine}");
            foreach (var gameResult in _dbContext.GameResults.Where(c => c.IsActive == true))
            {
                Console.WriteLine("{0,-8} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10}",
                    $"{gameResult.Id}",
                    $"{gameResult.NumberOfPlayerWins}",
                    $"{gameResult.NumberOfComputerWins}",
                    $"{gameResult.AmountOfRounds}",
                    $"{gameResult.AveragePlayerWins}",
                    $"{gameResult.DateOfGameResult}");
                Console.WriteLine(
                    $"--------------------------------------------------------------------------------------");
            }

            return true;


        }



    }
}
