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
            while (true)
            {
                



            }





        }


        public void ChooseShapeToCreate()
        {
            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");
        }




    }
}
