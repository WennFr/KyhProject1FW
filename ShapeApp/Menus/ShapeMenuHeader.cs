using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services;

namespace ShapeApp.Menus
{
    public static class ShapeMenuHeader
    {
        public static void Shapes()
        {

            ColorService.ConsoleWriteLineDarkGreen("Shapes");
            Console.WriteLine("=========");

        }

        public static void CreateShapes()
        {

            ColorService.ConsoleWriteLineDarkGreen("Create Shapes");
            Console.WriteLine("= = = = = = = = = = = = =");

        }


        public static void ViewResults()
        {
            ColorService.ConsoleWriteLineDarkGreen($"View all shapes{Environment.NewLine}");
        }

        public static void EditResult()
        {
            ColorService.ConsoleWriteLineDarkGreen($"Edit shape {Environment.NewLine}");
        }

        public static void DeleteResult()
        {
            ColorService.ConsoleWriteLineDarkGreen($"Delete shape {Environment.NewLine}");
        }


    }
}
