using KyhProject1FW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.ShapeControllers
{
    public class ReadGeometricResult
    {
        private IDbContext _dbContext;
        public ReadGeometricResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
