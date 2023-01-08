using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class GameMenu
    {

        public void ShowGameMenu()
        {
            Console.WriteLine($"Rock,Paper,Scissors {Environment.NewLine}");
            Console.WriteLine("1) Play Game");
            Console.WriteLine("2) View Highscore");
        }


    }
}
