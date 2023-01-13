using ServiceLibrary.Interfaces;
using ServiceLibrary.Validations;

namespace ShapeApp.Menus;

public class ShapeMenu : IMenu
{
    private ICreateResult _createResult;
    private IDeleteResult _deleteResult;
    private IReadResult _readResult;
    private IUpdateResult _updateResult;

    public ShapeMenu(ICreateResult createResult, IReadResult readResult, IUpdateResult updateResult,
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
        Console.WriteLine($"Shapes {Environment.NewLine}");
        Console.WriteLine("1) Create");
        Console.WriteLine("2) View");
        Console.WriteLine("3) Edit");
        Console.WriteLine("4) Delete");
        Console.WriteLine("0) Go back to main menu");

        MenuSelection();
    }

    public bool MenuSelection()
    {
        var selectionMenuMaxLimit = 4;

        var selection = ValidateInput.ValidateSelection(selectionMenuMaxLimit);

        switch (selection)
        {
            case 1:
                _createResult.Create();
                break;
            case 2:
                _readResult.Read();
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