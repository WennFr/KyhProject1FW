using System.Drawing;


namespace MathLibrary
{
    public class GeometryCalculation
    {
        // private IShape _shape;

        private string _shape;
        private decimal _b;
        private decimal _h;


        public enum shapeEnum
        {
            Rectangle,
            Paralellogram,
            Triangle,
            Rhombus
        }

        public GeometryCalculation(string shape, decimal b, decimal h)
        {
            _shape = shape;
            _b = b;
            _h = h;

        }

        public decimal CalculatePerimiter()
        {

            var perimiter = 0m;

            if (Enum.TryParse<shapeEnum>(_shape, ignoreCase: true, out var type) && Enum.IsDefined(shapeEnum.Rectangle))
            {

                perimiter = 2 * _b + 2 * _h;

                return perimiter;
            }


            return perimiter;




        }


    }
}