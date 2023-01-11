using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;
using KyhProject1FW.Menus;
using KyhProject1FW.ShapeControllers;

namespace KyhProject1FW.Services
{
    public static class DIService
    {
        public static MainMenu InitializeMainMenuDI(IDbContext dbContext)
        {

            var geometricResultController = new GeometricResultController();

            return new MainMenu(
                new ShapeMenu(new CreateGeometricResult(dbContext), new ReadGeometricResult(dbContext),
                    new UpdateGeometricResult(dbContext), new DeleteGeometricResult(dbContext)),
                new CalculatorMenu(), new GameMenu());
        }


    }
}
