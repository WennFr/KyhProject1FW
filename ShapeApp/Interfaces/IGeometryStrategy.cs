using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Interfaces
{
    public interface IGeometryStrategy
    {
        IAreaPerimeter Execute(double a, double b, double c);
    }
}
