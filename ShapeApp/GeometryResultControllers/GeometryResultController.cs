using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Data;
using ServiceLibrary.Services;
using ShapeApp.Interfaces;

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

        public void DisplaySelection()
        {
            Console.WriteLine("Shape to create:");

            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");
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

            geometryResultToReturn.Input1 = Math.Round(input1,2);
            geometryResultToReturn.Input2 = Math.Round(input2,2);
            geometryResultToReturn.Input3 = Math.Round(input3,2);

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

            geometryResultToReturn.Perimeter = Math.Round(_areaPerimeter.Perimeter,2);
            geometryResultToReturn.Area = Math.Round(_areaPerimeter.Area,2);

            return geometryResultToReturn;

        }





    }
}
