using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Interfaces;
using ServiceLibrary.Interfaces;

namespace CalculatorApp.CalculationResultControllers
{
    public class CalculationResultController : ICalculationResultController
    {
        private IDbContext _dbContext;
        public CalculationResultController(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }







    }
}
