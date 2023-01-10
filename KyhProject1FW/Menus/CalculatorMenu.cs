using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;

namespace KyhProject1FW.Menus
{
    public class CalculatorMenu : IMenu
    {
        private IDbContext _dbContext;
        public CalculatorMenu(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Calculator {Environment.NewLine}");
            Console.WriteLine("1) Create");
            Console.WriteLine("2) View");
            Console.WriteLine("3) Edit");
            Console.WriteLine("4) Delete");
            Console.WriteLine("0) Go back to main menu");

            MenuSelection();
        }
        public void ChooseOperatorMenu()
        {
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) √");
            Console.WriteLine("6) %");
        }

        public bool MenuSelection()
        {
            var selectionMenuMaxLimit = 4;
            var selection = ValidateMenuSelection.ValidateSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                    return false;

            }
            return true;
        }





    }
}
