using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services;

namespace CalculatorApp.Menus
{
    public class CalculatorSubMenu
    {
        public static void DisplayAvailableOperatorsSelection()
        {
            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Operator: {Environment.NewLine}");
            ColorService.ConsoleWriteLineCyan($"1.+");
            ColorService.ConsoleWriteLineCyan($"2.-");
            ColorService.ConsoleWriteLineCyan($"3.*");
            ColorService.ConsoleWriteLineCyan($"4./");
            ColorService.ConsoleWriteLineCyan($"5.√");
            ColorService.ConsoleWriteLineCyan($"6.%:");

        }


    }
}
