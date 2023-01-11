using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Data;
using KyhProject1FW.Interfaces;
using KyhProject1FW.ShapeControllers;
using KyhProject1FW.Services;

namespace KyhProject1FW
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
