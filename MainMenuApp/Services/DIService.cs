using CalculatorApp.Menus;
using CalculatorApp;
using CalculatorApp.CalculationResultControllers;
using MainMenuApp.GeometryResultControllers;
using MainMenuApp.Menus;
using CalculatorApp.CalculatorStrategies;
using ServiceLibrary.Interfaces;
using ShapeApp;
using ShapeApp.Menus;

namespace MainMenuApp.Services
{
    public static class DIService
    {
        public static MainMenu InitializeMainMenuDI(IDbContext dbContext)
        {
            var geometryResultController = new GeometryResultController(dbContext);

            return new Menus.MainMenu(
                new ShapeApplication(
                    new ShapeMenu(
                        new CreateGeometryResult(dbContext,geometryResultController), 
                new ReadGeometryResult(dbContext), new UpdateGeometryResult(dbContext), new DeleteGeometryResult(dbContext))),

                new CalculatorApplication
                    (new CalculatorMenu(new CreateCalculationResult(dbContext,new CalculatorContext(),new AdditionStrategy(), new SubtractionStrategy(), new MultiplicationStrategy(), new DivisionStrategy()), new ReadCalculationResult(dbContext),
                        new UpdateCalculationResult(dbContext), new DeleteCalculationResult(dbContext))));




            

        }


    }
}
