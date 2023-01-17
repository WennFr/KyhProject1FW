using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameApp.Models;
using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace GameApp.GameResultControllers
{
    public class CreateGameResult : ICreateResult
    {
        private IDbContext _dbContext;
        private GameRound gameRound;
        public CreateGameResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create()
        {
            gameRound = new GameRound();


            RockPaperScissors();
            WhoIsGameWinner();

            double averageHumanWins = Math.Round(Convert.ToDouble(gameRound.HumanWin) / Convert.ToDouble(gameRound.Round),2);

            _dbContext.GameResults.Add(new GameResult()
            {
                NumberOfPlayerWins = gameRound.HumanWin,
                NumberOfComputerWins = gameRound.ComputerWin,
                AveragePlayerWins = averageHumanWins,
                AmountOfRounds = gameRound.Round,
                DateOfGameResult = DateTime.Now,
                IsActive = true

            });

            _dbContext.SaveChanges();
        }


        public void RockPaperScissors()
        {
            gameRound.Round = 0;

            var isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                gameRound.Round++;
                Console.WriteLine($"Round {gameRound.Round} HUMAN:{gameRound.HumanWin} COMPUTER:{gameRound.ComputerWin} {Environment.NewLine}");

                gameRound.Human.ChooseAction();
                gameRound.Computer.ChooseAction();
                GameEventDisplay();
                WhoIsRoundWinner();
                isRunning = ContinueOrExit();
            }

        }

        public bool ContinueOrExit()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Do you want to play again y/n?");
            var isTrue = UserInputService.ValidateTrueOrFalseUserChoice();

            if (isTrue)
                return true;

            return false;


        }

        public void WhoIsGameWinner()
        {
            if (gameRound.HumanWin > gameRound.ComputerWin)
            {
                Console.Clear();
                Console.WriteLine("Human won the game!");

            }

            else if (gameRound.HumanWin < gameRound.ComputerWin)
            {
                Console.Clear();
                Console.WriteLine("Computer won the game...");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Game ends in a draw.");
            }
            ServiceMessage.PressEnterToContinue();
        }

        public void WhoIsRoundWinner()
        {
            if (gameRound.Human.Action.ToUpper() == "ROCK" && gameRound.Computer.Action.ToUpper() == "SCISSORS" ||
                gameRound.Human.Action.ToUpper() == "SCISSORS" && gameRound.Computer.Action.ToUpper() == "PAPER" ||
                gameRound.Human.Action.ToUpper() == "PAPER" && gameRound.Computer.Action.ToUpper() == "ROCK")
            {

                Console.WriteLine($"Human won round {gameRound.Round}");
                gameRound.HumanWin++;
                ServiceMessage.PressEnterToContinue();
            }

            else if (gameRound.Computer.Action.ToUpper() == "ROCK" && gameRound.Human.Action.ToUpper() == "SCISSORS" ||
                gameRound.Computer.Action.ToUpper() == "SCISSORS" && gameRound.Human.Action.ToUpper() == "PAPER" ||
                     gameRound.Computer.Action.ToUpper() == "PAPER" && gameRound.Human.Action.ToUpper() == "ROCK")
            {
                Console.WriteLine($"Computer won round {gameRound.Round}");
                gameRound.ComputerWin++;
                ServiceMessage.PressEnterToContinue();
            }

            else
            {

                Console.WriteLine($"Round {gameRound.Round} ends in a draw.");
                ServiceMessage.PressEnterToContinue();
            }


        }

        public void GameEventDisplay()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("...rock");
            Thread.Sleep(1000);
            Console.WriteLine("...paper");
            Thread.Sleep(1000);
            Console.WriteLine("...SCISSORS");
            Thread.Sleep(1000);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"HUMAN: {gameRound.Human.Action.ToUpper()}");
            Console.WriteLine($"COMPUTER: {gameRound.Computer.Action.ToUpper()}");

        }








    }
}
