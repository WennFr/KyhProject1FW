using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Menus
{
    public static class ShapeMenuHeader
    {

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
