using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;
using KyhProject1FW.ShapeControllers;

namespace KyhProject1FW.Menus
{
    public static class MenuDependencyInjection
    {
        public static MainMenu InitializeMainMenu(IDbContext dbContext)
        {
            return new MainMenu(
                new ShapeMenu(new CreateGeometricResult(dbContext), new ReadGeometricResult(dbContext),
                    new UpdateGeometricResult(dbContext), new DeleteGeometricResult(dbContext)),
                new CalculatorMenu(), new GameMenu());
        }


    }
}
