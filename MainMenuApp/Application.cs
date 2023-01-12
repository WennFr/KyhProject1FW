using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Services;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Data;

namespace MainMenuApp
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
