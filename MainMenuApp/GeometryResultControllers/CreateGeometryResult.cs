using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Validations;

namespace MainMenuApp.GeometryResultControllers
{
    public class CreateGeometryResult : ICreateResult
    {
        private IDbContext _dbContext;
        private IController _controller;
        public CreateGeometryResult(IDbContext dbContext, IController controller)
        {
            _dbContext = dbContext;
            _controller = controller;
        }

        public void Create()
        {
            Console.Clear();
            while (true)
            {
                _controller.DisplaySelection();
                var userSelection = ValidateInput.ValidateSelection(4);

                if (userSelection == 0)
                    break;

                var shapeToUseForGeometryResult = _controller.ReturnShapeObject(userSelection);

                Console.WriteLine("Base: ");
                var baseInput = ValidateInput.ValidateDoubleInputAboveZero();

                Console.WriteLine("Height:");
                var heightInput = ValidateInput.ValidateDoubleInputAboveZero();

                //var calculate = new GeometryCalculation(shapeToUseForGeometricResult.TypeOfShape, baseInput, heightInput);

                //var perimiter = calculate.CalculatePerimiter();




            }


        }


    }
}
