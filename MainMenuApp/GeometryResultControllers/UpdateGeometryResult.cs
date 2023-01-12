using MainMenuApp.Interfaces;

namespace MainMenuApp.GeometryResultControllers
{
    public class UpdateGeometryResult : IUpdateResult
    {
        private IDbContext _dbContext;
        public UpdateGeometryResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update()
        {





        }


    }
}
