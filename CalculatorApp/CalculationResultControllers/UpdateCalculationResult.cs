using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Interfaces;
using CalculatorApp.Menus;
using ServiceLibrary.Interfaces;

namespace CalculatorApp.CalculationResultControllers
{
    public class UpdateCalculationResult : IUpdateResult
    {
        private IDbContext _dbContext;
        private IReadResult _readResult;
        private ICalculationResultController _controller;
        public UpdateCalculationResult(IDbContext dbContext, IReadResult readResult,ICalculationResultController controller)
        {
            _dbContext = dbContext;
            _readResult = readResult;
            _controller = controller;
        }

        public void Update()
        {
            while (true)
            {
                Console.Clear();
                MenuHeader.EditResult();

                if (!_readResult.Read())
                    break;



            }

        }



    }
}
