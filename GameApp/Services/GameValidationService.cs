using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services;
using static GameApp.Models.GameRound;

namespace GameApp.Services
{
    public static class GameValidationService
    {


        public static string ChooseAction()
        {
            action myAction;
            while (true)
            {
                ColorService.ConsoleWriteDarkCyan(">");
                if (Enum.TryParse<action>(Console.ReadLine(), ignoreCase: true, out myAction) && Enum.IsDefined(myAction))
                    return Convert.ToString(myAction);

               ColorService.ConsoleWriteLineRed($"{Environment.NewLine}You have to choose between rock, paper or scissors!");
            }




        }





    }
}
