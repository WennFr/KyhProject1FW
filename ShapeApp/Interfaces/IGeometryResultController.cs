using ServiceLibrary.Data;

namespace ServiceLibrary.Interfaces


{
    public interface IGeometryResultController
    {

        void DisplaySelection();
        Shape ReturnShapeObject(int userSelection);
        GeometryResult DefineGeometryResultInput(GeometryResult geometryResultToReturn);


    }
}
