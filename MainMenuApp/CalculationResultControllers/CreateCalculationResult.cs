using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace MainMenuApp.CalculationResultControllers
{
    public class CreateCalculationResult : ICreateResult
    {

        private IDbContext _dbContext;
        public CreateCalculationResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create()
        {




        }


    }
}
