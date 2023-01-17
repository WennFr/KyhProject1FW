
using ServiceLibrary.Interfaces;
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
            Console.WriteLine("2) View Highscore");
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
