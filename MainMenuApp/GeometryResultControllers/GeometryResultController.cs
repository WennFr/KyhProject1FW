using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Data;
using MainMenuApp.Interfaces;
using MainMenuApp.Menus.Data;

namespace MainMenuApp.ShapeControllers
{
    public class GeometryResultController : IController
    {
        private IDbContext _dbContext;
        public GeometryResultController(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public void DisplayShapeToCreate()
        {
            Console.WriteLine("Shape to create:");

            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");
        }


        public Shape InitiateShapeToCreate(int userSelection)
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
    }
}
