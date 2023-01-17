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
            Console.WriteLine("= = = = = = = = = = = = =");

        }

        public static void CreateShapes()
        {

            ColorService.ConsoleWriteLineDarkGreen("Create Shapes");
            Console.WriteLine("= = = = = = = = = = = = =");

        }


        public static void ViewResults()
        {
            Console.WriteLine($"View all Results{Environment.NewLine}");
        }

        public static void EditResult()
        {
            Console.WriteLine($"Edit result {Environment.NewLine}");
        }

        public static void DeleteResult()
        {
            Console.WriteLine($"Delete result {Environment.NewLine}");
        }


    }
}
