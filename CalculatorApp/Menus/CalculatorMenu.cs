using ServiceLibrary.Interfaces;
using ServiceLibrary.Messages;
using ServiceLibrary.Services;

namespace CalculatorApp.Menus
{
    public class CalculatorMenu : IMenu
    {
        private ICreateResult _createResult;
        private IDeleteResult _deleteResult;
        private IReadResult _readResult;
        private IUpdateResult _updateResult;

        public CalculatorMenu(ICreateResult createResult, IReadResult readResult, IUpdateResult updateResult,
            IDeleteResult deleteResult)
        {
            _createResult = createResult;
            _readResult = readResult;
            _updateResult = updateResult;
            _deleteResult = deleteResult;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Calculator {Environment.NewLine}");
            Console.WriteLine("1) Create");
            Console.WriteLine("2) View");
            Console.WriteLine("3) Edit");
            Console.WriteLine("4) Delete");
            Console.WriteLine("0) Go back to main menu");

            MenuSelection();
        }
        public void ChooseOperatorMenu()
        {
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) √");
            Console.WriteLine("6) %");
        }

        public bool MenuSelection()
        {
            var selectionMenuMaxLimit = 4;
            var selection = UserInputService.ValidateMenuSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    _createResult.Create();
                    break;
                case 2:
                    Console.Clear();
                    MenuHeader.ViewAllResults();
                    _readResult.Read();
                    ServiceMessage.PressEnterToContinue();
                    break;
                case 3:
                    _updateResult.Update();
                    break;
                case 4:
                    _deleteResult.Delete();
                    break;
                case 0:
                    return false;

            }
            return true;
        }





    }
}
