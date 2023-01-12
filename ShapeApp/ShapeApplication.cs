using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Menus.Menus;

namespace ShapeApp
{
    public class ShapeApplication
    {

        public void ShowMenu()
        {

            var shapeMenu = new ShapeMenu();
            shapeMenu.ShowMenu();

        }

    }
}
