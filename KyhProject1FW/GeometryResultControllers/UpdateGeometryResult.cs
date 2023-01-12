using KyhProject1FW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.ShapeControllers
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
