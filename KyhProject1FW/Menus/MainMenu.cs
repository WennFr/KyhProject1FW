using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class MainMenu
    {
        private ShapeMenu _shapeMenu;
        private CalculatorMenu _calculatorMenu;
        private GameMenu _gameMenu;
        public bool IsApplicationRunning { get; set; }

        public MainMenu()
        {
            IsApplicationRunning = true;
            _shapeMenu = new ShapeMenu();
            _calculatorMenu = new CalculatorMenu();
            _gameMenu = new GameMenu();
        }

        public virtual void ShowMenu()
        {
            while (IsApplicationRunning)
            {
                Console.Clear();
                Console.WriteLine($"Project 1 - Main Menu {Environment.NewLine}");
                Console.WriteLine("1) Shapes");
                Console.WriteLine("2) Calculator");
                Console.WriteLine("3) Rock,Paper,Scissors");
                Console.WriteLine("0) Quit");

                IsApplicationRunning = MenuSelection();
            }
        }
        public virtual bool MenuSelection()
        {
            var selectionMenuMaxLimit = 3;
            var selection = ValidateMenuSelection.ValidateSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    _shapeMenu.ShowMenu();
                    break;
                case 2:
                    _calculatorMenu.ShowMenu();
                    break;
                case 3:
                    _gameMenu.ShowMenu();
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
