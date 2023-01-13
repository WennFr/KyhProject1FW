using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace CalculatorApp.CalculationResultControllers
{
    public class UpdateCalculationResult : IUpdateResult
    {
        private IDbContext _dbContext;
        public UpdateCalculationResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update()
        {







        }



    }
}
