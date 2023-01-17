using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Interfaces
{
    public interface IGeometry
    {
        public decimal CalculateRectangelPerimiter(decimal b, decimal h);
        public decimal CalculateRectangelArea(decimal b, decimal h);
        public decimal CalculateParallelogramPerimiter(decimal b, decimal h);
        public decimal CalculateParallelogramArea(decimal b, decimal h);
        public decimal CalculateTrianglePerimiter(decimal b, decimal h);
        public decimal CalculateTriangleArea(decimal b, decimal h);
        public decimal CalculateRhombusPerimiter(decimal b, decimal h);
        public decimal CalculateRhombusArea(decimal b, decimal h);

    }
}
