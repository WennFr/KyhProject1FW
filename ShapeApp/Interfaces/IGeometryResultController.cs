using ServiceLibrary.Data;

namespace ServiceLibrary.Interfaces


{
    public interface IGeometryResultController
    {

        void DisplaySelection();
        Shape ReturnShapeObject(int userSelection);
        GeometryResult DefineGeometryResultInput(GeometryResult geometryResultToReturn);
        GeometryResult CalculateNewGeometryResultStrategyPattern(GeometryResult geometryResultToReturn);
        GeometryResult ChooseResultToReturn();
        void DisplayChosenResult(GeometryResult geometryResultToUpdate);
        bool IsShapeTriangle(string typeOfShape);
    }
}
