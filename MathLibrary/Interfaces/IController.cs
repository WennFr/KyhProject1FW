using ServiceLibrary.Data;

namespace ServiceLibrary.Interfaces


{
    public interface IController
    {

        void DisplaySelection();

        Shape ReturnShapeObject(int userSelection);


    }
}
