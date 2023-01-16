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

        public IAreaPerimeter Execute(double x, double y, double z)
        {
            _areaPerimeter.Perimeter = x + y + z;

            double p = _areaPerimeter.Perimeter / 2;

            //Heron's Formula
            _areaPerimeter.Area = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            return _areaPerimeter;
        }


    }
}
