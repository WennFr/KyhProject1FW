using KyhProject1FW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.ShapeControllers
{
    public class DeleteGeometryResult : IDeleteResult
    {
        private IDbContext _dbContext;
        public DeleteGeometryResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete()
        {





        }



    }
}
