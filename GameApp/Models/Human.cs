using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameApp.Services;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace GameApp.Models
{
    public class Human
    {
        private string action;


        public string Action
        {
            get { return action; }

            set
            {
                if (value.ToLower() == "rock" || value.ToLower() == "paper" || value.ToLower() == "scissors")
                    action = value;

                else
                    action = null;
            }
        }

        public void ChooseAction()
        {

            ColorService.ConsoleWriteLineWhite($"{Environment.NewLine}[1]Rock, [2]Paper or [3]Scissors?");
            var userChoice = GameValidationService.ChooseAction();

            action = userChoice;

            //else
            //{
            //    Console.WriteLine("You have to choose between rock, paper or scissors");
            //    Console.WriteLine(Environment.NewLine);
            //    ServiceMessage.PressEnterToContinue();
            //    return false;
            //}

        }
    }
}
