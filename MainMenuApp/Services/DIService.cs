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
            var calculationResultController = new CalculationResultController(dbContext, new CalculatorContext(), new AdditionStrategy(),
                new SubtractionStrategy(), new MultiplicationStrategy(), new DivisionStrategy(), new SquareRootStrategy(), new ModuloStrategy());
            var readCalculationResult = new ReadCalculationResult(dbContext);

            return new MainMenu(
                new ShapeApplication(
                    new ShapeMenu(
                        new CreateGeometryResult(dbContext,geometryResultController), 
                new ReadGeometryResult(dbContext), new UpdateGeometryResult(dbContext), new DeleteGeometryResult(dbContext))),

                new CalculatorApplication
                    (new CalculatorMenu(new CreateCalculationResult(dbContext,calculationResultController), 
                        readCalculationResult,
                        new UpdateCalculationResult(dbContext,readCalculationResult,calculationResultController), new DeleteCalculationResult(dbContext))));




            

        }


    }
}
