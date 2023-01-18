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

            var averageHumanWins = GameWinAverageInPercent(gameRound.HumanWin,gameRound.ComputerWin);

            _dbContext.GameResults.Add(new GameResult()
            {
                NumberOfPlayerWins = gameRound.HumanWin,
                NumberOfComputerWins = gameRound.ComputerWin,
                AveragePlayerWinsPercentage = averageHumanWins,
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
                ScoreMenu();

                gameRound.Human.ChooseAction();
                gameRound.Computer.ChooseAction();
                GameEventDisplay();
                DisplayRoundScore();
                WhoIsRoundWinner();
                isRunning = ContinueOrExit();
            }

        }

        public bool ContinueOrExit()
        {
            Console.WriteLine(Environment.NewLine);
            ColorService.ConsoleWriteLineDarkCyan("Do you want to play again y/n?");
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
                ColorService.ConsoleWriteGreen("HUMAN ");
                ColorService.ConsoleWriteWhite($"won the game!{Environment.NewLine}");

            }

            else if (gameRound.HumanWin < gameRound.ComputerWin)
            {
                Console.Clear();
                ColorService.ConsoleWriteRed("COMPUTER ");
                ColorService.ConsoleWriteWhite($"won the game...{Environment.NewLine}");

            }

            else
            {
                Console.Clear();
                ColorService.ConsoleWriteWhite($"Game ends in a draw. {Environment.NewLine}");
            }
            ServiceMessage.PressEnterToContinue();
        }

        public void WhoIsRoundWinner()
        {
            if (gameRound.Human.Action.ToUpper() == "ROCK" && gameRound.Computer.Action.ToUpper() == "SCISSORS" ||
                gameRound.Human.Action.ToUpper() == "SCISSORS" && gameRound.Computer.Action.ToUpper() == "PAPER" ||
                gameRound.Human.Action.ToUpper() == "PAPER" && gameRound.Computer.Action.ToUpper() == "ROCK")
            {

                ColorService.ConsoleWriteLineWhite($"{Environment.NewLine}Human won round {gameRound.Round}!");
                gameRound.HumanWin++;
            }

            else if (gameRound.Computer.Action.ToUpper() == "ROCK" && gameRound.Human.Action.ToUpper() == "SCISSORS" ||
                gameRound.Computer.Action.ToUpper() == "SCISSORS" && gameRound.Human.Action.ToUpper() == "PAPER" ||
                     gameRound.Computer.Action.ToUpper() == "PAPER" && gameRound.Human.Action.ToUpper() == "ROCK")
            {
                ColorService.ConsoleWriteLineWhite($"{Environment.NewLine}Computer won round {gameRound.Round}...");
                gameRound.ComputerWin++;
            }

            else
            {
                ColorService.ConsoleWriteLineWhite($"{Environment.NewLine}Round {gameRound.Round} ends in a draw.");
            }

        }

        public void GameEventDisplay()
        {
            Console.WriteLine(Environment.NewLine);
            ColorService.ConsoleWriteLineDarkMagenta("...rock");
            Thread.Sleep(900);
            ColorService.ConsoleWriteLineCyan("...paper");
            Thread.Sleep(900);
            ColorService.ConsoleWriteLineYellow("...SCISSORS");
            Thread.Sleep(900);
            Console.WriteLine(Environment.NewLine);
        }


        public void ScoreMenu()
        {
            ColorService.ConsoleWriteYellow($"Round:");
            ColorService.ConsoleWriteWhite($" {gameRound.Round} ");
            ColorService.ConsoleWriteGreen("HUMAN:");
            ColorService.ConsoleWriteWhite($"{gameRound.HumanWin} ");
            ColorService.ConsoleWriteRed("COMPUTER:");
            ColorService.ConsoleWriteWhite($"{gameRound.ComputerWin} {Environment.NewLine}");
        }

        public void DisplayRoundScore()
        {
            //Console.WriteLine($"HUMAN: {gameRound.Human.Action.ToUpper()}");
            ColorService.ConsoleWriteGreen($"HUMAN: ");
            ColorService.ConsoleWriteWhite($"{gameRound.Human.Action.ToUpper()}{Environment.NewLine}");

            ColorService.ConsoleWriteRed($"COMPUTER: ");
            ColorService.ConsoleWriteWhite($"{gameRound.Computer.Action.ToUpper()}{Environment.NewLine}");

        }

        public double GameWinAverageInPercent(int humanWins, int computerWin)
        {


          return 100 * Math.Round(Convert.ToDouble(gameRound.HumanWin) / Convert.ToDouble(gameRound.Round), 2);

        }
    }
}
