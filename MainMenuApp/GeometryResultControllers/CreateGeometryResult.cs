using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Menus.Data;
using MainMenuApp.Menus.Interfaces;
using MainMenuApp.Menus.Validations;
using MathLibrary;

namespace MainMenuApp.Menus.ShapeControllers
{
    public class CreateGeometryResult : ICreateResult
    {
        private IDbContext _dbContext;
        private GeometryResultController _controller;
        public CreateGeometryResult(IDbContext dbContext, GeometryResultController controller)
        {
            _dbContext = dbContext;
            _controller = controller;
        }

        public void Create()
        {
            Console.Clear();
            while (true)
            {
                _controller.DisplayShapeToCreate();
                var userSelection = ValidateMenuSelection.ValidateSelection(4);

                if (userSelection == 0)
                    break;

                var shapeToUseForGeometricResult = _controller.InitiateShapeToCreate(userSelection);

                Console.WriteLine("Base: ");
                var baseInput = ValidateUserInput.ValidateDecimalInputAboveZero();

                Console.WriteLine("Height:");
                var heightInput = ValidateUserInput.ValidateDecimalInputAboveZero();

                var calculate = new GeometryCalculation(shapeToUseForGeometricResult.TypeOfShape, baseInput, heightInput);

                var perimiter = calculate.CalculatePerimiter();


                

            }


        }


    }
}
