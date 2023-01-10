using KyhProject1FW.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Data;
using KyhProject1FW.Interfaces;
using KyhProject1FW.ShapeControllers;

namespace KyhProject1FW
{
    public class Application
    {
        public void Run()
        {
            Builder.BuildDatabase();
            IDbContext dbContext = Builder.InitializeData();
            var mainMenu = MenuDependencyInjection.InitializeMainMenu(dbContext);
            mainMenu.ShowMenu();



        }

    }
}
