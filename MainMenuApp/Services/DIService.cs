using MainMenuApp.GeometryResultControllers;
using MainMenuApp.Interfaces;
using MainMenuApp.Menus;
using MainMenuApp.ShapeControllers;
using ServiceLibrary.Interfaces;

namespace MainMenuApp.Services
{
    public static class DIService
    {
        public static MainMenu InitializeMainMenuDI(IDbContext dbContext, IValidateServices validateServices)
        {
            var geometricResultController = new GeometryResultController(dbContext);

            return new MainMenu(validateServices);
        }


    }
}
