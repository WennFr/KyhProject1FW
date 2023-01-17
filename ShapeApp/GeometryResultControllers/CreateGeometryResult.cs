using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;
using ShapeApp.Interfaces;
using ShapeApp.Menus;
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

                _geometryResultToCreate = new GeometryResult();

                Console.Clear();
                ShapeMenuHeader.CreateShapes();
                ShapeSubMenu.DisplayAvailableShapesSelection();
                var userSelection = UserInputService.ValidateMenuSelection(4);

                if (userSelection == 0)
                    break;

                var shapeToUseForGeometryResult = _controller.ReturnShapeObject(userSelection);

                _geometryResultToCreate.Shape = shapeToUseForGeometryResult;
                Console.Clear();
                ShapeMenuHeader.CreateShapes();
                _geometryResultToCreate = _controller.DefineGeometryResultInput(_geometryResultToCreate);
                _geometryResultToCreate = _controller.CalculateNewGeometryResultStrategyPattern(_geometryResultToCreate);

                if (MathErrorExceptionService.IsInvalidArea(_geometryResultToCreate.Area))
                    continue;

                _geometryResultToCreate.IsActive = true;
                _geometryResultToCreate.DateOfGeometryResult = DateTime.Now;
                _dbContext.GeometryResults.Add(_geometryResultToCreate);
                _dbContext.SaveChanges();

                Console.Clear();
                _controller.DisplayChosenResult(_geometryResultToCreate);
                ServiceMessage.Sucess();
                Console.WriteLine($"{Environment.NewLine}Create new result?(y/n)");
                var isNewCalculation = UserInputService.ValidateTrueOrFalseUserChoice();
                if (!isNewCalculation)
                    break;

            }


        }


    }
}
