using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CalculatorApp.Menus
{
    public static class MenuHeader
    {

        public static void ViewResults()
        {
            Console.WriteLine($"View all Results{Environment.NewLine}");
        }

        public static void EditResult()
        {
            Console.WriteLine($"Edit result {Environment.NewLine}");
        }



    }
}
