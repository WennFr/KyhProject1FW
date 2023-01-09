using KyhProject1FW.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW
{
    public class Application
    {
        public void Run()
        {

            var mainMenu = new MainMenu(new ShapeMenu(), new CalculatorMenu(), new GameMenu());
            mainMenu.ShowMenu();

        }

    }
}
