using MainMenuApp.Interfaces;

namespace MainMenuApp.GeometryResultControllers
{
    public class ReadGeometryResult : IReadResult
    {
        private IDbContext _dbContext;
        public ReadGeometryResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Read()
        {





        }


    }
}
