using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;
using KyhProject1FW.Validations;

namespace KyhProject1FW.ShapeControllers
{
    public class CreateGeometricResult : ICreateResult
    {
        private IDbContext _dbContext;
        private IController _controller;
        public CreateGeometricResult(IDbContext dbContext, IController controller)
        {
            _dbContext = dbContext;
            _controller = controller;
        }

        public void Create()
        {
            while (true)
            {
                var userSelection = ValidateMenuSelection.ValidateSelection(4);
                






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
