using ServiceLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Menus
{
    public static class GameMenuHeader
    {

        public static void GameHeader()
        {
            ColorService.ConsoleWriteLineWhite($"Rock,Paper,Scissors");
            Console.WriteLine("===================");

        }

    }
}
