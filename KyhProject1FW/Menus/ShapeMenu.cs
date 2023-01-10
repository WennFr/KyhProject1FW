using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;

namespace KyhProject1FW.Menus
{
    public class ShapeMenu : IMenu
    {
        private IDbContext _dbContext;
        public ShapeMenu(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public  void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Shapes {Environment.NewLine}");
            Console.WriteLine("1) Create");
            Console.WriteLine("2) View");
            Console.WriteLine("3) Edit");
            Console.WriteLine("4) Delete");
            Console.WriteLine("0) Go back to main menu");

            MenuSelection();

        }
        public void CreateShapeMenu()
        {
            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");

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
