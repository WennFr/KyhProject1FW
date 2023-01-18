using ServiceLibrary.Data;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;
using ShapeApp.Menus;

namespace ShapeApp.GeometryResultControllers
{
    public class UpdateGeometryResult : IUpdateResult
    {
        private IDbContext _dbContext;
        private IReadResult _readResult;
        private IGeometryResultController _controller;
        public UpdateGeometryResult(IDbContext dbContext, IReadResult readResult, IGeometryResultController controller)
        {
            _dbContext = dbContext;
            _readResult = readResult;
            _controller = controller;
        }

        public void Update()
        {
            while (true)
            {

                Console.Clear();
                ShapeMenuHeader.EditResult();
                var isAnyActiveResults = _readResult.Read();

                if (!isAnyActiveResults)
                {
                    ServiceMessage.PressEnterToContinue();
                    break;
                }

                var resultToUpdate = _controller.ChooseResultToReturn();

                var isRunning = true;

                while (isRunning)
                {
                    Console.Clear();
                    ShapeMenuHeader.EditResult();

                    _controller.DisplayChosenResult(resultToUpdate);

                    ShapeSubMenu.DisplayUpdateShapesSelection();

                    var userSelection = UserInputService.ValidateMenuSelection(4);
                    var newValue = 0.00;
                    var oldValue = 0.00;
                    var oldArea = resultToUpdate.Area;
                    var oldPerimeter = resultToUpdate.Perimeter;
                    var oldShape = resultToUpdate.Shape;
                    switch (userSelection)
                    {
                        case 1:
                            resultToUpdate = UpdateValue1(newValue, oldValue, oldPerimeter, oldArea, resultToUpdate);
                            continue;

                        case 2:
                            resultToUpdate = UpdateValue2(newValue, oldValue, oldPerimeter, oldArea, resultToUpdate);
                            continue;

                        case 3:
                            if (!_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                                continue;

                            resultToUpdate = UpdateValue3(newValue, oldValue, oldPerimeter, oldArea, resultToUpdate);
                            continue;

                        case 4:
                            resultToUpdate = UpdateShape(newValue, oldValue, oldPerimeter, oldShape, resultToUpdate);
                            continue;

                        case 0:
                            _dbContext.SaveChanges();
                            isRunning = false;
                            break;
                    }

                }

                break;
            }

        }

        public GeometryResult UpdateValue1(double newValue, double oldValue, double oldPerimeter, double oldArea, GeometryResult resultToUpdate)
        {
            oldValue = resultToUpdate.Input1;
            if (_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Side1 (base):");
            else
                ColorService.ConsoleWriteLineDarkCyan("Base: ");

            newValue = UserInputService.ValidateDoubleInputAboveZero();

            resultToUpdate.Input1 = newValue;
            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);
            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
            {
                resultToUpdate.Input1 = oldValue;
                resultToUpdate.Perimeter = oldPerimeter;
                resultToUpdate.Area = oldArea;

                return resultToUpdate;
            }

            return resultToUpdate;
        }

        public GeometryResult UpdateValue2(double newValue, double oldValue, double oldPerimeter, double oldArea, GeometryResult resultToUpdate)
        {


            oldValue = resultToUpdate.Input2;

            if (_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Side2:");

            else
                ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Height: ");

            newValue = UserInputService.ValidateDoubleInputAboveZero();

            resultToUpdate.Input2 = newValue;
            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);

            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
            {
                resultToUpdate.Input2 = oldValue;
                resultToUpdate.Perimeter = oldPerimeter;
                resultToUpdate.Area = oldArea;

                return resultToUpdate;
            }

            return resultToUpdate;
        }

        public GeometryResult UpdateValue3(double newValue, double oldValue, double oldPerimeter, double oldArea, GeometryResult resultToUpdate)
        {
            oldValue = resultToUpdate.Input3;

            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Side3:");
            newValue = UserInputService.ValidateDoubleInputAboveZero();

            resultToUpdate.Input3 = newValue;
            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);

            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
            {
                resultToUpdate.Input3 = oldValue;
                resultToUpdate.Perimeter = oldPerimeter;
                resultToUpdate.Area = oldArea;
                return resultToUpdate;
            }

            return resultToUpdate;
        }


        public GeometryResult UpdateShape(double newValue, double oldPerimeter, double oldArea, Shape oldShape, GeometryResult resultToUpdate)
        {
            Console.Clear();

            ShapeSubMenu.DisplayAvailableShapesSelection();
            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}What do shape do you want? {Environment.NewLine}");
            var userSelection = UserInputService.ValidateMenuSelection(4);

            if (userSelection == 0)
                return resultToUpdate;

            resultToUpdate.Shape = _controller.ReturnShapeObject(userSelection);

            if (!_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                resultToUpdate.Input3 = 0.00;

            else if (_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape) &&
                     resultToUpdate.Input3 <= 0)
            {
                ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Side3:");

                newValue = UserInputService.ValidateDoubleInputAboveZero();
                resultToUpdate.Input3 = newValue;
            }

            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);

            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
            {
                resultToUpdate.Shape = oldShape;
                resultToUpdate.Perimeter = oldPerimeter;
                resultToUpdate.Area = oldArea;

                return resultToUpdate;
            }

            return resultToUpdate;

        }








    }
}
