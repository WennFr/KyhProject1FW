using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Menus
{
    public class CalculatorSubMenu
    {
        public static void DisplayAvailableOperatorsSelection()
        {
            Console.Write($"{Environment.NewLine}Operator: {Environment.NewLine}");
            Console.WriteLine($"1.+");
            Console.WriteLine($"2.-");
            Console.WriteLine($"3.*");
            Console.WriteLine($"4./");
            Console.WriteLine($"5.√");
            Console.WriteLine($"6.%:");

        }


    }
}
