using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Menus
{
    public static class ShapeSubMenu
    {

        public static void DisplayAvailableShapesSelection()
        {
            Console.WriteLine($"Shape to create:{Environment.NewLine}");

            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");
        }

        public static void DisplayUpdateShapesSelection()
        {
            Console.WriteLine($"{Environment.NewLine}What do you want to edit? {Environment.NewLine}");
            Console.WriteLine("1) Value 1");
            Console.WriteLine("2) Value 2");
            Console.WriteLine("3) Value 3 (if triangle)");
            Console.WriteLine("4) Shape");
            Console.WriteLine("0) Save and exit");

        }


    }
}
