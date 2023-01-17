using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Data;
using ServiceLibrary.Services;
using ShapeApp.Interfaces;
using ServiceLibrary.Messages;
using ShapeApp.Menus;

namespace ShapeApp.GeometryResultControllers
{
    public class GeometryResultController : IGeometryResultController
    {
        private IDbContext _dbContext;
        private IGeometryContext _geometryContext;
        private IAreaPerimeter _areaPerimeter;
        private IGeometryStrategy _rectangleStrategy;
        private IGeometryStrategy _parallelogramStrategy;
        private IGeometryStrategy _triangleStrategy;
        private IGeometryStrategy _rhombusStrategy;


        public GeometryResultController(IDbContext dbContext, IGeometryContext context, IAreaPerimeter areaPerimeter,
            IGeometryStrategy rectangleStrategy, IGeometryStrategy parallelogramStrategy, IGeometryStrategy triangleStrategy, IGeometryStrategy rhombusStrategy)
        {
            _dbContext = dbContext;
            _geometryContext = context;
            _areaPerimeter = areaPerimeter;
            _rectangleStrategy = rectangleStrategy;
            _parallelogramStrategy = parallelogramStrategy;
            _triangleStrategy = triangleStrategy;
            _rhombusStrategy = rhombusStrategy;
        }


        public bool IsShapeTriangle(string typeOfShape)
        {
            Shape.shape validShape;
            if (Enum.TryParse<Shape.shape>(typeOfShape, out validShape) && validShape == Shape.shape.Triangle)
                return true;

            return false;
        }

        public Shape ReturnShapeObject(int userSelection)
        {
            Shape shapeToReturn;

            switch (userSelection)
            {
                case 1:
                    return shapeToReturn = _dbContext.Shapes.FirstOrDefault(s =>
                        s.TypeOfShape == Convert.ToString(Shape.shape.Rectangle));
                case 2:
                    return shapeToReturn = _dbContext.Shapes.FirstOrDefault(s =>
                          s.TypeOfShape == Convert.ToString(Shape.shape.Parallelogram));
                case 3:
                    return shapeToReturn = _dbContext.Shapes.FirstOrDefault(s =>
                          s.TypeOfShape == Convert.ToString(Shape.shape.Triangle));
                case 4:
                    return shapeToReturn = _dbContext.Shapes.FirstOrDefault(s =>
                         s.TypeOfShape == Convert.ToString(Shape.shape.Rhombus));
            }
            return null;
        }

        public GeometryResult DefineGeometryResultInput(GeometryResult geometryResultToReturn)
        {
            Shape.shape validShape;
            double input1, input2, input3 = 0.00;
            if (Enum.TryParse<Shape.shape>(geometryResultToReturn.Shape.TypeOfShape, out validShape) && validShape == Shape.shape.Triangle)
            {
                Console.WriteLine("Side 1(base):");
                input1 = UserInputService.ValidateDoubleInputAboveZero();
                Console.WriteLine("Side 2");
                input2 = UserInputService.ValidateDoubleInputAboveZero();
                Console.WriteLine("Side 3:");
                input3 = UserInputService.ValidateDoubleInputAboveZero();

            }
            else
            {
                Console.WriteLine("Base: ");
                input1 = UserInputService.ValidateDoubleInputAboveZero();
                Console.WriteLine("Height:");
                input2 = UserInputService.ValidateDoubleInputAboveZero();
            }

            geometryResultToReturn.Input1 = Math.Round(input1, 2);
            geometryResultToReturn.Input2 = Math.Round(input2, 2);
            geometryResultToReturn.Input3 = Math.Round(input3, 2);

            return geometryResultToReturn;
        }


        public GeometryResult CalculateNewGeometryResultStrategyPattern(GeometryResult geometryResultToReturn)
        {
            Shape.shape validShape;
            Enum.TryParse<Shape.shape>(geometryResultToReturn.Shape.TypeOfShape, out validShape);

            switch (validShape)
            {
                case Shape.shape.Rectangle:
                    _geometryContext.SetStrategy(_rectangleStrategy);
                    break;

                case Shape.shape.Parallelogram:
                    _geometryContext.SetStrategy(_parallelogramStrategy);
                    break;

                case Shape.shape.Triangle:
                    _geometryContext.SetStrategy(_triangleStrategy);
                    break;

                case Shape.shape.Rhombus:
                    _geometryContext.SetStrategy(_rhombusStrategy);
                    break;
            }

            _areaPerimeter = _geometryContext.ExecuteStrategy(geometryResultToReturn.Input1, geometryResultToReturn.Input2, geometryResultToReturn.Input3);

            geometryResultToReturn.Perimeter = Math.Round(_areaPerimeter.Perimeter, 2);
            geometryResultToReturn.Area = Math.Round(_areaPerimeter.Area, 2);

            return geometryResultToReturn;

        }

        public GeometryResult ChooseResultToReturn()
        {

            int intSelection;
            Console.WriteLine($"Choose id to select:");
            while (true)
            {
                Console.WriteLine(">");
                if (int.TryParse(Console.ReadLine(), out intSelection) &&
                    _dbContext.GeometryResults.Any(c => c.Id == intSelection && c.IsActive == true))
                {
                    var geometryResultToReturn = _dbContext.GeometryResults.FirstOrDefault(s => s.Id == intSelection);
                    Console.Clear();
                    return geometryResultToReturn;
                }

                ProgramErrorMessage.ChooseBetweenAvailableMenuNumbers();
            }

        }

        public void DisplayChosenResult(GeometryResult geometryResultToUpdate)
        {

            Console.WriteLine("{0,-10} {1,-13} {2,-10} {3,-10} {4,-10} {5,-15} {6,-10} {7,-10}", $"{Environment.NewLine}ID", "Shape", "Value1", "Value2", "Value3",
                "Perimeter", "Area", $"Date of result {Environment.NewLine}");

            {
                Console.WriteLine("{0,-8} {1,-13} {2,-10} {3,-10} {4,-10} {5,-15} {6,-10} {7,-10}",
                    $"{geometryResultToUpdate.Id}",
                    $"{geometryResultToUpdate.Shape.TypeOfShape}",
                    $"{geometryResultToUpdate.Input1}",
                    $"{geometryResultToUpdate.Input2}",
                    $"{geometryResultToUpdate.Input3}",
                    $"{geometryResultToUpdate.Perimeter}",
                    $"{geometryResultToUpdate.Area}",
                    $"{geometryResultToUpdate.DateOfGeometryResult}");

                Console.WriteLine(
                    $"----------------------------------------------------------------------------------------------------------------");
            }


        }








    }
}
