using System.Drawing;
using CalculatorApp.Menus;
using CalculatorApp;
using CalculatorApp.CalculationResultControllers;
using ShapeApp.GeometryResultControllers;
using MainMenuApp.Menus;
using CalculatorApp.CalculatorStrategies;
using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ShapeApp;
using ShapeApp.GeometryStrategies;
using ShapeApp.Menus;
using ShapeApp.Models;

namespace MainMenuApp.Services
{
    public static class DIService
    {
        public static MainMenu InitializeMainMenuDI(IDbContext dbContext)
        {

            var areaPerimeter = new AreaPerimeter();
            var geometryResultController = new GeometryResultController(dbContext,new GeometryContext(),areaPerimeter, new RectangleStrategy(areaPerimeter),
                new ParallelogramStrategy(areaPerimeter), new TriangleStrategy(areaPerimeter), new RhombusStrategy(areaPerimeter));
            var readGeometryResult = new ReadGeometryResult(dbContext);



            var calculationResultController = new CalculationResultController(dbContext, new CalculatorContext(), new AdditionStrategy(),
                new SubtractionStrategy(), new MultiplicationStrategy(), new DivisionStrategy(), new SquareRootStrategy(), new ModuloStrategy());
            var readCalculationResult = new ReadCalculationResult(dbContext);

            

            return new MainMenu(

                new ShapeApplication(new ShapeMenu(new CreateGeometryResult(dbContext,geometryResultController,new GeometryResult()), 
                new ReadGeometryResult(dbContext), new UpdateGeometryResult(dbContext,readGeometryResult,geometryResultController), new DeleteGeometryResult(dbContext))),

                new CalculatorApplication(new CalculatorMenu(new CreateCalculationResult(dbContext,calculationResultController),readCalculationResult,
                        new UpdateCalculationResult(dbContext,readCalculationResult,calculationResultController),
                        new DeleteCalculationResult(dbContext,readCalculationResult, calculationResultController))));




            

        }


    }
}
