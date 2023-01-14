using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Services
{
    public static class MathService
    {
        public static bool IsInfinity(double number)
        {
            if (Double.IsInfinity(number))
            {
                Console.WriteLine("Overflow");
                Console.ReadKey();
                return true;
            }
            return false;

        }


        public static bool IsDividedByZero(double num1, double num2)
        {
            if (Double.IsInfinity(num1 / num2))
            {
                Console.WriteLine("Error: " + "Attempted to divide by zero");
                Console.ReadKey();
                return true;
            }

            return false;
        }



        public static bool IsSquareRootOfNegativeNumber(double num1)
        {
            if (num1 < 0)
            {
                Console.WriteLine("Error: " + "Square root of negative number");
                Console.ReadKey();
                return true;
            }

            return false;

        }


    }
}
