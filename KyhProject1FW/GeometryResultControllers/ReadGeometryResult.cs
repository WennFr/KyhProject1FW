using KyhProject1FW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.ShapeControllers
{
    public class ReadGeometryResult : IReadResult
    {
        private IDbContext _dbContext;
        public ReadGeometryResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Read()
        {





        }


    }
}
