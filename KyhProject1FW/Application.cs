using KyhProject1FW.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Data;
using KyhProject1FW.Interfaces;

namespace KyhProject1FW
{
    public class Application
    {
        public void Run()
        {
            Builder.BuildDatabase();
            IDbContext dbContext = Builder.InitializeData();
            var mainMenu = new MainMenu(new ShapeMenu(), new CalculatorMenu(), new GameMenu());
            mainMenu.ShowMenu();


        }

    }
}
