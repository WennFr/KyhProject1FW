using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class ShapesMenu : MainMenu
    {

        public ShapesMenu()
        {
            
        }
        public override void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Shapes {Environment.NewLine}");
            Console.WriteLine("1) Create shapes");
            Console.WriteLine("2) View shapes");
            Console.WriteLine("3) Edit shapes");
            Console.WriteLine("4) Delete shapes");
            Console.WriteLine("0) Go back to main menu");

            MenuSelection();

        }
        public void ChooseAShapeToCreateMenu()
        {
            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");

        }

        public override bool MenuSelection()
        {
            var selectionMenuMaxLimit = 4;

            var selection = ValidateMenuSelection(selectionMenuMaxLimit);

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
