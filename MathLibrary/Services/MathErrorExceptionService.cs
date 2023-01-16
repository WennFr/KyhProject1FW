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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Overflow");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                return true;
            }
            return false;

        }


        public static bool IsDividedByZero(double num1, double num2, char op)
        {


            if (Double.IsInfinity(num1 / num2) && op == '/' || num1 == 0 && num2 == 0 && op == '/')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + "Attempted to divide by zero");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                return true;
            }

            return false;
        }



        public static bool IsSquareRootOfNegativeNumber(double num1, char op)
        {
            if (num1 < 0 && op == '√')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + "Square root of negative number");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.ReadKey();
                return true;
            }

            return false;

        }


        public static bool IsInvalidArea(double areaToControl)
        {
            if (Double.IsNaN(areaToControl))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + "Impossible shape");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                return true;
            }


            return false;
        }



    }
}
