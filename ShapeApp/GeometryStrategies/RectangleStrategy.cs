using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeApp.Interfaces;
using ShapeApp.Models;

namespace ShapeApp.GeometryStrategies
{
    public class RectangleStrategy : IGeometryStrategy
    {
        private IAreaPerimeter _areaPerimeter;

        public RectangleStrategy(IAreaPerimeter areaPerimeter)
        {
            _areaPerimeter = areaPerimeter;
        }

       public IAreaPerimeter Execute(double a, double b, double c)
       {

           return _areaPerimeter;

       }



    }
}
