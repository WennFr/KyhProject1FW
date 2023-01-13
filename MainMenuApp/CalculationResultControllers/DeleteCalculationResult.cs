using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace MainMenuApp.CalculationResultControllers
{
    public class DeleteCalculationResult : IDeleteResult
    {
        private IDbContext _dbContext;
        public DeleteCalculationResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Delete()
        {






        }


    }
}
