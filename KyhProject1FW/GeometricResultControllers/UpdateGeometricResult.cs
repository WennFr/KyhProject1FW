using KyhProject1FW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.ShapeControllers
{
    public class UpdateGeometricResult
    {
        private IDbContext _dbContext;
        public UpdateGeometricResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
