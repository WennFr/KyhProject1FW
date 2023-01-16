using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Services;
using ShapeApp.Interfaces;
using ShapeApp.Models;


namespace ShapeApp.GeometryResultControllers
{
    public class CreateGeometryResult : ICreateResult
    {
        private IDbContext _dbContext;
        private IGeometryResultController _controller;
        private GeometryResult _geometryResultToCreate;
        public CreateGeometryResult(IDbContext dbContext, IGeometryResultController controller, GeometryResult geometryResultToCreate)
        {
            _dbContext = dbContext;
            _controller = controller;
            _geometryResultToCreate = geometryResultToCreate;
        }

        public void Create()
        {

            while (true)
            {
                Console.Clear();
                _controller.DisplaySelection();
                var userSelection = UserInputService.ValidateMenuSelection(4);

                if (userSelection == 0)
                    break;

                var shapeToUseForGeometryResult = _controller.ReturnShapeObject(userSelection);

                _geometryResultToCreate.Shape = shapeToUseForGeometryResult;
                _geometryResultToCreate = _controller.DefineGeometryResultInput(_geometryResultToCreate);
                _geometryResultToCreate = _controller.CalculateNewGeometryResultStrategyPattern(_geometryResultToCreate);
                _geometryResultToCreate.IsActive = true;
                _geometryResultToCreate.DateOfGeometryResult = DateTime.Now;

                _dbContext.GeometryResults.Add(_geometryResultToCreate);
                _dbContext.SaveChanges();


                Console.WriteLine($"{Environment.NewLine}Create new shape?(y/n)");
                var isNewCalculation = UserInputService.ValidateTrueOrFalseUserChoice();
                if (!isNewCalculation)
                    break;

            }


        }


    }
}
