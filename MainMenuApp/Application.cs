using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Interfaces;
using MainMenuApp.Data;
using MainMenuApp.Services;
using ServiceLibrary;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Validations;

namespace MainMenuApp.Menus
{
    public class Application
    {
        public IValidateServices ValidateServices { get; set; } = new ValidateInput();
        public void Run()
        {
            Builder.BuildDatabase();
            IDbContext dbContext = Builder.InitializeData();
            var mainMenu = DIService.InitializeMainMenuDI(dbContext, ValidateServices);
            mainMenu.ShowMenu();


        }

    }
}
