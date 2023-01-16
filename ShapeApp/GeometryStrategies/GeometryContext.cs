using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeApp.Interfaces;

namespace ShapeApp.GeometryStrategies
{
    public class GeometryContext : IGeometryContext
    {
        private IGeometryStrategy _strategy;

        public void SetStrategy(IGeometryStrategy strategy)
        {
            _strategy = strategy;
        }

        public IAreaPerimeter ExecuteStrategy(double x, double y, double z)
        {
            return _strategy.Execute(x, y, z);
        }


    }

}
