using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class MainMenu
    {
        private ShapesMenu shapesMenu;
        private CalculatorMenu calculatorMenu;
        private GameMenu gameMenu;
        public bool IsApplicationRunning  { get; set; }

        public MainMenu()
        {
            IsApplicationRunning = true;
            shapesMenu = new ShapesMenu();
            calculatorMenu = new CalculatorMenu();
            gameMenu = new GameMenu();
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
            var selection = ValidateMenuSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    shapesMenu.ShowMenu();
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
        public int ValidateMenuSelection(int selectionMenuMaxLimit)
        {
            int intSelection;
            Console.WriteLine($"{Environment.NewLine}Välj i menyn:");
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
