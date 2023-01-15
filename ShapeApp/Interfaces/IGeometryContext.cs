using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Interfaces
{
    public interface IGeometryContext
    {

        public void SetStrategy(IGeometryStrategy strategy);
        public IAreaPerimeter ExecuteStrategy(double a, double b, double c);

    }
}
