using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeApp.Interfaces;

namespace ShapeApp.Models
{
    public class AreaPerimeter : IAreaPerimeter
    {
        public double Area { get; set; }
        public double Perimiter { get; set; }

    }
}
