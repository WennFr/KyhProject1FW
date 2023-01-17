
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;

namespace ShapeApp.GeometryResultControllers
{
    public class ReadGeometryResult : IReadResult
    {
        private IDbContext _dbContext;
        public ReadGeometryResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Read()
        {

            if (_dbContext.GeometryResults.Count() < 0 || !_dbContext.GeometryResults.Any(c => c.IsActive == true))
            {
                ProgramErrorMessage.NoActiveResultsToView();
                ServiceMessage.PressEnterToContinue();
                return false;
            }

            Console.WriteLine("{0,-10} {1,-13} {2,-10} {3,-10} {4,-10} {5,-15} {6,-10} {7,-10}", $"{Environment.NewLine}ID", "Shape", "Value1", "Value2", "Value3", 
                "Perimeter", "Area", $"Date of result {Environment.NewLine}");

            foreach (var geometryResult in _dbContext.GeometryResults.Where(c => c.IsActive == true).Include(s=> s.Shape))
            {
                Console.WriteLine("{0,-8} {1,-13} {2,-10} {3,-10} {4,-10} {5,-15} {6,-10} {7,-10}",
                    $"{geometryResult.Id}",
                    $"{geometryResult.Shape.TypeOfShape}",
                    $"{geometryResult.Input1}",
                    $"{geometryResult.Input2}",
                    $"{geometryResult.Input3}",
                    $"{geometryResult.Perimeter}",
                    $"{geometryResult.Area}",
                    $"{geometryResult.DateOfGeometryResult}");

                    Console.WriteLine(
                    $"----------------------------------------------------------------------------------------------------------------");
            }

            return true;



        }


    }
}
