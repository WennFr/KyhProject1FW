using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Interfaces;
using MainMenuApp.Menus.Data;
using MainMenuApp.Services;

namespace MainMenuApp.Menus
{
    public class Application
    {
        public void Run()
        {
            Builder.BuildDatabase();
            IDbContext dbContext = Builder.InitializeData();
            var mainMenu = DIService.InitializeMainMenuDI(dbContext);
            mainMenu.ShowMenu();


        }

    }
}
