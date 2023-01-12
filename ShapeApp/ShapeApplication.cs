using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;
using ShapeApp.Menus;

namespace ShapeApp
{
    public class ShapeApplication : IProject
    {
        private IMenu _shapeMenu;
        public ShapeApplication(IMenu shapeMenu)
        {
            _shapeMenu = shapeMenu;
        }
        public void StartApplication()
        {
            _shapeMenu.ShowMenu();
        }

    }
}
