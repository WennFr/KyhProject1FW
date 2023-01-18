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
            CalcMenuHeader.Calculator();
            ColorService.ConsoleWriteLineCyan("1) Create");
            ColorService.ConsoleWriteLineCyan("2) View");
            ColorService.ConsoleWriteLineCyan("3) Edit");
            ColorService.ConsoleWriteLineCyan("4) Delete");
            Console.WriteLine("0) Go back to main menu");

            MenuSelection();
        }
        
        public bool MenuSelection()
        {
            var selectionMenuMaxLimit = 4;
            var selection = UserInputService.ValidateMenuSelection(selectionMenuMaxLimit);

            switch (selection)
            {
                case 1:
                    _createResult.Create();
                    ShowMenu();
                    break;
                case 2:
                    Console.Clear();
                    CalcMenuHeader.ViewResults();
                    _readResult.Read();
                    ServiceMessage.PressEnterToContinue();
                    ShowMenu();
                    break;
                case 3:
                    _updateResult.Update();
                    ShowMenu();
                    break;
                case 4:
                    _deleteResult.Delete();
                    ShowMenu();
                    break;
                case 0:
                    return false;

            }
            return true;
        }





    }
}
