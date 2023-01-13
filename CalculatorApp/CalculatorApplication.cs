using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace CalculatorApp
{
    public class CalculatorApplication : IProject
    {
        private IMenu _calculatorMenu;
        public CalculatorApplication(IMenu calculatorMenu)
        {
            _calculatorMenu = calculatorMenu;
        }
        public void StartApplication()
        {
            _calculatorMenu.ShowMenu();
        }


    }
}
