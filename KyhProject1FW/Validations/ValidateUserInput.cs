using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Validations
{
    public static class ValidateUserInput
    {
        public static decimal ValidateDecimalInputAboveZero()
        {
                decimal decimalSelection;
                while (true)
                {
                   // Console.Write(">");
                    if (decimal.TryParse(Console.ReadLine(), out decimalSelection) && decimalSelection > 0 )
                    {
                        return decimalSelection;
                    }
                    Console.WriteLine("Please write a valid number above zero:");
                }

        }


    }
}
