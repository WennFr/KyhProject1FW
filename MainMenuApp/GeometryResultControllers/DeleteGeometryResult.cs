using MainMenuApp.Interfaces;

namespace MainMenuApp.GeometryResultControllers
{
    public class DeleteGeometryResult : IDeleteResult
    {
        private IDbContext _dbContext;
        public DeleteGeometryResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete()
        {





        }



    }
}
