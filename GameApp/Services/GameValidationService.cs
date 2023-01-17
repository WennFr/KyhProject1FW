using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameApp.Models.GameRound;

namespace GameApp.Services
{
    public static class GameValidationService
    {

        public static bool IsValidAction(string typeOfAction)
        {
            action myAction;
            while (true)
            {
                if (Enum.TryParse<action>(typeOfAction, out myAction))
                    return true;

                Console.WriteLine($"{Environment.NewLine}Pick rock, paper or scissors!");
            }

        }

        public static string ChooseAction()
        {
            action myAction;
            while (true)
            {
                Console.Write(">");
                if (Enum.TryParse<action>(Console.ReadLine(), out myAction))
                    return Convert.ToString(myAction);

                Console.WriteLine($"{Environment.NewLine}You have to choose between rock, paper or scissors!");
            }




        }





    }
}
