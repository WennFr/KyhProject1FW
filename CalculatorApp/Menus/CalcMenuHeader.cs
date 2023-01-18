using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ServiceLibrary.Services;

namespace CalculatorApp.Menus
{
    public static class CalcMenuHeader
    {
        public static void Calculator()
        {
            ColorService.ConsoleWriteLineBlue("Calculator");
            Console.WriteLine("=============");

        }

        public static void CreateCalculation()
        {

            ColorService.ConsoleWriteLineBlue("Calculation");
            Console.WriteLine("= = = = = = = = = = = = =");

        }
        public static void ViewResults()
        {
            ColorService.ConsoleWriteLineBlue($"View all Results{Environment.NewLine}");
        }

        public static void EditResult()
        {
            ColorService.ConsoleWriteLineBlue($"Edit result {Environment.NewLine}");
        }

        public static void DeleteResult()
        {
            ColorService.ConsoleWriteLineBlue($"Delete result {Environment.NewLine}");
        }


    }
}
