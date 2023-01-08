using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class MainMenu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine($"Project 1 - Main Menu {Environment.NewLine}");
            Console.WriteLine("1) Shapes");
            Console.WriteLine("2) Calculator");
            Console.WriteLine("3) Rock,Paper,Scissors");
            Console.WriteLine("0) Quit");
        }
    
    }
}
