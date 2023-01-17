﻿
using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace GameApp.Menus
{
    public class GameMenu : IMenu
    {
        private ICreateResult _create;
        private IReadResult _read;
        public GameMenu(ICreateResult create, IReadResult read)
        {
            _create = create;
            _read = read;
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Rock,Paper,Scissors {Environment.NewLine}");
            Console.WriteLine("1) Play Game");
            Console.WriteLine("2) View Results");
            Console.WriteLine("0) Go back to main menu");


            MenuSelection();
        }

        public bool MenuSelection()
        {
            var selectionMenuMaxLimit = 2;
            var selection = UserInputService.ValidateMenuSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    _create.Create();
                    break;
                case 2:
                    _read.Read();
                    ServiceMessage.PressEnterToContinue();
                    break;
                case 0:
                    return false;
            }

            return true;
        }





    }
}
