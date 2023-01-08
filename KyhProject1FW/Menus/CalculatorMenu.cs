using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class CalculatorMenu
    {

        public void ShowCalculatorMenu()
        {
            Console.WriteLine($" Calculator {Environment.NewLine}");
            Console.WriteLine("1) Create calculations");
            Console.WriteLine("2) View calculations");
            Console.WriteLine("3) Edit calculations");
            Console.WriteLine("4) Delete calculations");
            Console.WriteLine("0) Go back to main menu");

        }
        public void ChooseAnOperatorMenu()
        {
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) √");
            Console.WriteLine("6) %");
        }


    }
}
