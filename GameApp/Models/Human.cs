using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Messages;

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


        public bool ChooseAction()
        {
            
                Console.WriteLine("Rock, paper or scissors?");
                Console.Write(">");
                var userChoice = Console.ReadLine();



                if (userChoice.ToLower() == "rock" || userChoice.ToLower() == "paper" ||
                    userChoice.ToLower() == "scissors")
                {
                    action = userChoice;
                    return true;

                }

                else
                {
                    Console.WriteLine("You have to choose between rock, paper or scissors");
                    Console.WriteLine(Environment.NewLine);
                    ServiceMessage.PressEnterToContinue();
                    return false;
                }
            







        }
    }
}
