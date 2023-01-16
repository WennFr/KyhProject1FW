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

       public IAreaPerimeter Execute(double x, double y, double z)
       {

           _areaPerimeter.Perimeter = (2 * x) + (2 * y);
           _areaPerimeter.Area = x * y;

           return _areaPerimeter;

       }



    }
}
