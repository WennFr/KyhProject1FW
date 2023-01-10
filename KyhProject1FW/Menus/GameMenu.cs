﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;

namespace KyhProject1FW.Menus
{
    public class GameMenu : IMenu
    {
        private IDbContext _dbContext;
        public GameMenu(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Rock,Paper,Scissors {Environment.NewLine}");
            Console.WriteLine("1) Play Game");
            Console.WriteLine("2) View Highscore");
            Console.WriteLine("0) Go back to main menu");


            MenuSelection();
        }

        public bool MenuSelection()
        {
            var selectionMenuMaxLimit = 2;

            var selection = ValidateMenuSelection.ValidateSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 0:
                    return false;
            }

            return true;
        }





    }
}
