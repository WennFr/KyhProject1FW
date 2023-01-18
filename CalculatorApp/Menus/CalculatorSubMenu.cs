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


        public static void DisplayUpdateCalculatorSelectionOneNumber()
        {

            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}What do you want to edit? {Environment.NewLine}");
            ColorService.ConsoleWriteLineCyan("1) First number");
            ColorService.ConsoleWriteLineCyan("2) Operator");
            ColorService.ConsoleWriteLineGreen("0) Save and exit");

        }

        public static void DisplayUpdateCalculatorSelectionTwoNumbers()
        {

            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}What do you want to edit? {Environment.NewLine}");
            ColorService.ConsoleWriteLineCyan("1) First number");
            ColorService.ConsoleWriteLineCyan("2) Operator");
            ColorService.ConsoleWriteLineCyan("3) Second number");
            ColorService.ConsoleWriteLineGreen("0) Save and exit");

        }



    }
}
