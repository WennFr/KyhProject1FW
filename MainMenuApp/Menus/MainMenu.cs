using ServiceLibrary.Interfaces;
using ServiceLibrary.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuApp.Menus
{
    public class MainMenu
    {
        private IProject _shapeApplication;
            private IProject _calculatorProject;
            private IProject _gameProject;


            //private IMenu _gameMenu;
            public bool IsApplicationRunning { get; set; }

            public MainMenu( IProject shapeApplication)
            {
                IsApplicationRunning = true;
                _shapeApplication = shapeApplication;

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
                var selection = ValidateInput.ValidateSelection(selectionMenuMaxLimit);

                switch (selection)
                {
                    case 1:
                        _shapeApplication.StartApplication();
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
