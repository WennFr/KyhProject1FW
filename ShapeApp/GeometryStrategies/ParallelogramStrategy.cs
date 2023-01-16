using ShapeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.GeometryStrategies
{
    public class ParallelogramStrategy : IGeometryStrategy
    {
        private IAreaPerimeter _areaPerimeter;

        public ParallelogramStrategy(IAreaPerimeter areaPerimeter)
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
