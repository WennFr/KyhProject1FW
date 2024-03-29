﻿using ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameApp;
using ServiceLibrary.Services;

namespace MainMenuApp.Menus
{
    public class MainMenu
    {
        private IProject _shapeApplication;
        private IProject _calculatorApplication;
        private IProject _gameApplication;


        //private IMenu _gameMenu;
        public bool IsApplicationRunning { get; set; }

        public MainMenu(IProject shapeApplication, IProject calculatorApplication, IProject gameApplication)
        {
            IsApplicationRunning = true;
            _shapeApplication = shapeApplication;
            _calculatorApplication = calculatorApplication;
            _gameApplication = gameApplication;
        }
        public void ShowMenu()
        {
            while (IsApplicationRunning)
            {
                Console.Clear();
                ColorService.ConsoleWriteLineCyan($"Project 1 - Main Menu {Environment.NewLine}");
                ColorService.ConsoleWriteLineDarkGreen("1) Shapes");
                ColorService.ConsoleWriteLineBlue("2) Calculator");
                ColorService.ConsoleWriteLineWhite("3) Rock,Paper,Scissors");
                ColorService.ConsoleWriteLineRed("0) Quit");
                
                IsApplicationRunning = MenuSelection();
            }
        }
        public bool MenuSelection()
        {
            var selectionMenuMaxLimit = 3;
            var selection = UserInputService.ValidateMenuSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    _shapeApplication.StartApplication();
                    break;
                case 2:
                    _calculatorApplication.StartApplication();
                    break;
                case 3:
                    _gameApplication.StartApplication();
                    break;
                case 0:
                    return false;

            }
            return true;
        }





    }
}
