
using ServiceLibrary.Interfaces;

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

            return true;



        }


    }
}
