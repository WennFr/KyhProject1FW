using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Data;
using KyhProject1FW.Interfaces;
using KyhProject1FW.Validations;

namespace KyhProject1FW.ShapeControllers
{
    public class CreateGeometricResult : ICreateResult
    {
        private IDbContext _dbContext;
        private IController _controller;
        public CreateGeometricResult(IDbContext dbContext, IController controller)
        {
            _dbContext = dbContext;
            _controller = controller;
        }

        public void Create()
        {
            Console.Clear();
            var isRunning = true;
            while (isRunning)
            {
                ChooseShapeToCreate();
                var userSelection = ValidateMenuSelection.ValidateSelection(4);
                Shape shapeToUseForGeometricResult;
                switch (userSelection)
                {
                    case 1:
                         shapeToUseForGeometricResult = _dbContext.Shapes.FirstOrDefault(s =>
                            s.TypeOfShape == Convert.ToString(Shape.shape.Rectangle));
                        break;
                    case 2:
                        shapeToUseForGeometricResult = _dbContext.Shapes.FirstOrDefault(s =>
                            s.TypeOfShape == Convert.ToString(Shape.shape.Paralellogram));
                        break;
                    case 3:
                        shapeToUseForGeometricResult = _dbContext.Shapes.FirstOrDefault(s =>
                            s.TypeOfShape == Convert.ToString(Shape.shape.Triangle));
                        break;
                    case 4:
                        shapeToUseForGeometricResult = _dbContext.Shapes.FirstOrDefault(s =>
                            s.TypeOfShape == Convert.ToString(Shape.shape.Rhombus));
                        break;
                    case 0:
                        isRunning = false;
                        break;
                }







            }


        }

        public void ChooseShapeToCreate()
        {
            Console.WriteLine($"Choose a shape to create: {Environment.NewLine}");

            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");
        }

    }
}
