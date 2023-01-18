using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services;

namespace ShapeApp.Menus
{
    public static class ShapeSubMenu
    {

        public static void DisplayAvailableShapesSelection()
        {

            ColorService.ConsoleWriteLineGreen("1) Rectangle");
            ColorService.ConsoleWriteLineGreen("2) Parallelogram");
            ColorService.ConsoleWriteLineGreen("3) Triangle");
            ColorService.ConsoleWriteLineGreen("4) Rhombus");
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
