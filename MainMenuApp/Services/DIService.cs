using MainMenuApp.GeometryResultControllers;
using MainMenuApp.Interfaces;
using MainMenuApp.Menus;

namespace MainMenuApp.Services
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
