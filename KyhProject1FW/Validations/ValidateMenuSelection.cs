using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Validations
{
    public static class ValidateMenuSelection
    {
        public static int ValidateSelection(int selectionMenuMaxLimit)
        {
            int intSelection;
            Console.WriteLine($"{Environment.NewLine}Menu select:");
            while (true)
            {
                Console.Write("> ");
                if (int.TryParse(Console.ReadLine(), out intSelection) && intSelection >= 0 && intSelection <= selectionMenuMaxLimit)
                    return intSelection;

                Console.WriteLine("Choose between the available menu numbers");
            }
        }

    }
}
