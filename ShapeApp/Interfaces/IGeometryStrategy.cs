using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Interfaces
{
    public interface IGeometryStrategy
    {
        IAreaPerimeter Execute(double x, double y, double z);
    }
}
