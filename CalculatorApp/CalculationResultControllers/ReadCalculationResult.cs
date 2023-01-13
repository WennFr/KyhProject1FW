using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace CalculatorApp.CalculationResultControllers
{
    public class ReadCalculationResult : IReadResult
    {
        private IDbContext _dbContext;
        public ReadCalculationResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Read()
        {








        }



    }
}
