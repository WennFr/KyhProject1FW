using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace GameApp
{
    public class GameApplication : IProject
    {
        private IMenu _gameMenu;
        public GameApplication(IMenu gameMenu)
        {
            _gameMenu = gameMenu;
        }


        public void StartApplication()
        {
            _gameMenu.ShowMenu();
        }
    }
}
