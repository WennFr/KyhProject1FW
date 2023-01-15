using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Data;
using ServiceLibrary.Services;

namespace ShapeApp.GeometryResultControllers 
{
    public class GeometryResultController : IGeometryResultController
    {
        private IDbContext _dbContext;
        public GeometryResultController(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
                          s.TypeOfShape == Convert.ToString(Shape.shape.Paralellogram));
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
                Console.WriteLine("Side 1:");
                input1 = UserInputService.ValidateDoubleInputAboveZero();
                Console.WriteLine("Side 2");
                input2 = UserInputService.ValidateDoubleInputAboveZero();
                Console.WriteLine("Side 3:");
                input3 = UserInputService.ValidateDoubleInputAboveZero();

            }
            else
            {
                Console.WriteLine("Base: ");
                var baseInput = UserInputService.ValidateDoubleInputAboveZero();
                Console.WriteLine("Height:");
                var heightInput = UserInputService.ValidateDoubleInputAboveZero();
            }

            return geometryResultToReturn;
        }



    }
}
