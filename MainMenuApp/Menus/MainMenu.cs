using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Interfaces;
using ServiceLibrary.Interfaces;
using ShapeApp;


namespace MainMenuApp.Menus
{
    public class MainMenu
    {
        private IValidateServices _validateServices;
        //private IMenu _calculatorMenu;
        //private IMenu _gameMenu;
        public bool IsApplicationRunning { get; set; }

        public MainMenu(IValidateServices validateServices)
        {
            IsApplicationRunning = true;
            _validateServices = validateServices;
            //_calculatorMenu = calculatorMenu;
            //_gameMenu = gameMenu;

        }

        public void ShowMenu()
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
        public bool MenuSelection()
        {
            var selectionMenuMaxLimit = 3;
            var selection = _validateServices.ValidateSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    var shapeApplication = new ShapeApplication();
                    shapeApplication.ShowMenu();
                    break;
                case 2:
                    //_calculatorMenu.ShowMenu();
                    break;
                case 3:
                    //_gameMenu.ShowMenu();
                    break;
                case 0:
                    return false;

            }
            return true;
        }
       

    }
}
