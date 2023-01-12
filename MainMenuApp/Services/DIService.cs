using MainMenuApp.GeometryResultControllers;
using MainMenuApp.GeometryResultControllers;
using MainMenuApp.Menus;
using ServiceLibrary.Interfaces;
using ShapeApp;
using ShapeApp.Menus;

namespace MainMenuApp.Services
{
    public static class DIService
    {
        public static MainMenu InitializeMainMenuDI(IDbContext dbContext)
        {
            var geometricResultController = new GeometryResultController(dbContext);

            return new Menus.MainMenu(new ShapeApplication(new ShapeMenu(new CreateGeometryResult(dbContext,geometricResultController), 
                new ReadGeometryResult(dbContext), new UpdateGeometryResult(dbContext), new DeleteGeometryResult(dbContext))));
        }


    }
}
