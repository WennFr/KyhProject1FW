using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Services
{
    public static class MathErrorExceptionService
    {
        public static bool IsInfinity(double number)
        {
            if (Double.IsInfinity(number))
            {
                ColorService.ConsoleWriteLineRed("Overflow");
                Console.ReadKey();
                return true;
            }
            return false;

        }


        public static bool IsDividedByZero(double num1, double num2, char op)
        {


            if (Double.IsInfinity(num1 / num2) && op == '/' || num1 == 0 && num2 == 0 && op == '/')
            {
                ColorService.ConsoleWriteLineRed("Error: " + "Attempted to divide by zero");
                Console.ReadKey();
                return true;
            }

            return false;
        }

        public static bool IsSquareRootOfNegativeNumber(double num1, char op)
        {
            if (num1 < 0 && op == '√')
            {
                ColorService.ConsoleWriteLineRed("Error: " + "Square root of negative number");
                Console.ReadKey();
                return true;
            }

            return false;

        }

        public static bool IsInvalidArea(double areaToControl)
        {
            if (Double.IsNaN(areaToControl))
            {
                ColorService.ConsoleWriteLineRed("Error: " + "Impossible shape");
                Console.ReadKey();
                return true;
            }

            return false;
        }



    }
}
