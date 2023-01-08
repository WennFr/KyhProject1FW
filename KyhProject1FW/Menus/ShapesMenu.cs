using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class ShapesMenu
    {
        public void ShowShapesMenu()
        {
            Console.WriteLine($" Shapes {Environment.NewLine}");
            Console.WriteLine("1) Create shapes");
            Console.WriteLine("2) View shapes");
            Console.WriteLine("3) Edit shapes");
            Console.WriteLine("4) Delete shapes");
            Console.WriteLine("0) Go back to main menu");

        }
        public void ChooseAShapeToCreateMenu()
        {
            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");

        }


    }
}
