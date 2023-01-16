using ShapeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.GeometryStrategies
{
    public class TriangleStrategy : IGeometryStrategy
    {
        private IAreaPerimeter _areaPerimeter;

        public TriangleStrategy(IAreaPerimeter areaPerimeter)
        {
            _areaPerimeter = areaPerimeter;
        }

        public IAreaPerimeter Execute(double a, double b, double c)
        {
            return _areaPerimeter;
        }


    }
}
