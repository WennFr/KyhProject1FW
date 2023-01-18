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
            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}What do you want to edit? {Environment.NewLine}");
            ColorService.ConsoleWriteLineGreen("1) Value 1");
            ColorService.ConsoleWriteLineGreen("2) Value 2");
            ColorService.ConsoleWriteLineGreen("3) Value 3 (if triangle)");
            ColorService.ConsoleWriteLineGreen("4) Shape");
            Console.WriteLine("0) Save and exit");

        }


    }
}
