using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;

namespace KyhProject1FW.ShapeControllers
{
    public class CreateGeometricResult : ICreateResult
    {
        private IDbContext _dbContext;
        public CreateGeometricResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create()
        {



        }
        
    }
}
