using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;
using ShapeApp.Menus;

namespace ShapeApp.GeometryResultControllers
{
    public class DeleteGeometryResult : IDeleteResult
    {
        private IDbContext _dbContext;
        private IReadResult _readResult;
        private IGeometryResultController _controller;

        public DeleteGeometryResult(IDbContext dbContext,IReadResult readResult ,IGeometryResultController controller)
        {
            _dbContext = dbContext;
            _readResult = readResult;   
            _controller = controller;
        }

        public void Delete()
        {

            while (true)
            {
                Console.Clear();
                ShapeMenuHeader.DeleteResult();

                var isAnyActiveResults = _readResult.Read();
                if (!isAnyActiveResults)
                {
                    ServiceMessage.PressEnterToContinue();
                    break;
                }
               
                var resultToDelete = _controller.ChooseResultToReturn();

                Console.WriteLine($"{Environment.NewLine}Are you sure you want to delete this result? y/n");
                var isDeleteResult = UserInputService.ValidateTrueOrFalseUserChoice();
                if (!isDeleteResult)
                {
                    Console.WriteLine("Process cancelled.");
                    ServiceMessage.PressEnterToContinue();
                    break;

                }

                resultToDelete.IsActive = false;
                _dbContext.SaveChanges();

                Console.Clear();
                Console.WriteLine("Result was deleted.");
                ServiceMessage.PressEnterToContinue();
                break;

            }



        }



    }
}
