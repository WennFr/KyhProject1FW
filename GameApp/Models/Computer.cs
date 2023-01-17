using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Models
{
    public  class Computer
    {

        private string[] RockPaperScissors = new string[] { "Rock", "Paper", "Scissors" };
        private string action;




        public string Action
        {
            get
            {
                return action;
            }


        }
        public void ChooseAction()
        {
            Random random = new Random();
            action = $"{RockPaperScissors[random.Next(RockPaperScissors.Length)]}";


        }





    }
}
