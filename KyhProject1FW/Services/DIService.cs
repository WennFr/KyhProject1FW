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
            var geometricResultController = new GeometryResultController(dbContext);

            return new MainMenu(
                new ShapeMenu(new CreateGeometryResult(dbContext,geometricResultController), new ReadGeometryResult(dbContext),
                    new UpdateGeometryResult(dbContext), new DeleteGeometryResult(dbContext)),
                new CalculatorMenu(), new GameMenu());
        }


    }
}
