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
                    break;

                var resultToUpdate = _controller.ChooseResultToReturn();

                var isRunning = true;

                while (isRunning)
                {
                    Console.Clear();
                    _controller.DisplayChosenResult(resultToUpdate);

                    Console.WriteLine($"{Environment.NewLine}What do you want to edit? {Environment.NewLine}");
                    Console.WriteLine("1) Value 1");
                    Console.WriteLine("2) Value 2");
                    Console.WriteLine("3) Value 3 (if triangle)");
                    Console.WriteLine("4) Shape");
                    Console.WriteLine("0) Save and exit");

                    var userSelection = UserInputService.ValidateMenuSelection(4);
                    var newValue = 0.00;
                    var oldValue = 0.00;
                    var oldArea =  resultToUpdate.Area;
                    var oldPerimeter = resultToUpdate.Perimeter;
                    switch (userSelection)
                    {
                        case 1:
                            oldValue = resultToUpdate.Input1;
                            if (_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                                Console.Write($"{Environment.NewLine}Side1 (base):");
                            else
                                Console.WriteLine("Base: ");

                            newValue = UserInputService.ValidateDoubleInputAboveZero();

                            resultToUpdate.Input1 = newValue;
                            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);
                            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
                            {
                                resultToUpdate.Input1 = oldValue;
                                resultToUpdate.Perimeter = oldPerimeter;
                                resultToUpdate.Area = oldArea;
                            }

                            continue;

                        case 2:

                            oldValue = resultToUpdate.Input2;

                            if (_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                                Console.Write($"{Environment.NewLine}Side2:");

                            else
                                Console.WriteLine($"{Environment.NewLine}Height: ");

                            newValue = UserInputService.ValidateDoubleInputAboveZero();

                            resultToUpdate.Input2 = newValue;
                            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);

                            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
                            {
                                resultToUpdate.Input2 = oldValue;
                                resultToUpdate.Perimeter = oldPerimeter;
                                resultToUpdate.Area = oldArea;
                            }

                            continue;

                        case 3:
                            oldValue = resultToUpdate.Input3;
                            if (!_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                                continue;

                            Console.Write($"{Environment.NewLine}Side3:");
                            newValue = UserInputService.ValidateDoubleInputAboveZero();

                            resultToUpdate.Input3 = newValue;
                            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);

                            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
                            {
                                resultToUpdate.Input3 = oldValue;
                                resultToUpdate.Perimeter = oldPerimeter;
                                resultToUpdate.Area = oldArea;
                            }

                            continue;



                        case 4:
                            Console.Clear();
                            var oldShape = resultToUpdate.Shape;

                            _controller.DisplaySelection();
                            Console.WriteLine($"{Environment.NewLine}What do shape do you want? {Environment.NewLine}");
                            userSelection = UserInputService.ValidateMenuSelection(4);

                            resultToUpdate.Shape = _controller.ReturnShapeObject(userSelection);

                            if (!_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape))
                                resultToUpdate.Input3 = 0.00;

                            else if (_controller.IsShapeTriangle(resultToUpdate.Shape.TypeOfShape) &&
                                     resultToUpdate.Input3 <= 0)
                            {
                                Console.Write($"{Environment.NewLine}Side3:");

                                newValue = UserInputService.ValidateDoubleInputAboveZero();
                                resultToUpdate.Input3 = newValue;
                            }

                            resultToUpdate = _controller.CalculateNewGeometryResultStrategyPattern(resultToUpdate);

                            if (MathErrorExceptionService.IsInvalidArea(resultToUpdate.Area))
                            {
                                resultToUpdate.Shape = oldShape;
                                resultToUpdate.Perimeter = oldPerimeter;
                                resultToUpdate.Area = oldArea;
                            }

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


    }
}
