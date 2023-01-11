using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Data;
using KyhProject1FW.Interfaces;
using KyhProject1FW.Validations;

namespace KyhProject1FW.ShapeControllers
{
    public class CreateGeometricResult : ICreateResult
    {
        private IDbContext _dbContext;
        private GeometricResultController _controller;
        public CreateGeometricResult(IDbContext dbContext, GeometricResultController controller)
        {
            _dbContext = dbContext;
            _controller = controller;
        }

        public void Create()
        {
            Console.Clear();
            while (true)
            {
                _controller.DisplayShapeToCreate();
                var userSelection = ValidateMenuSelection.ValidateSelection(4);

                if (userSelection == 0)
                    break;

                var shapeToUseForGeometricResult = _controller.InitiateShapeToCreate(userSelection);

                Console.WriteLine("Write ");




            }


        }


    }
}
