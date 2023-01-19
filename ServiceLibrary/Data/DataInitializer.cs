using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Data
{
    public class DataInitializer
    {
        private ApplicationDbContext dbContext { get; set; }

        public DataInitializer(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public void Migrate()
        {
            dbContext.Database.Migrate();
        }

        public void Seed()
        {
            SeedShapes();
            dbContext.SaveChanges();
            SeedGeometryResults();
            dbContext.SaveChanges();

        }

        public void SeedShapes()
        {
            if (!dbContext.Shapes.Any())
            {
                dbContext.Shapes.Add(new Shape()
                {
                    TypeOfShape = "Rectangle",
                    CreatedDate = DateTime.Now
                });
                dbContext.Shapes.Add(new Shape()
                {
                    TypeOfShape = "Parallelogram",
                    CreatedDate = DateTime.Now
                });
                dbContext.Shapes.Add(new Shape()
                {
                    TypeOfShape = "Triangle",
                    CreatedDate = DateTime.Now
                });
                dbContext.Shapes.Add(new Shape()
                {
                    TypeOfShape = "Rhombus",
                    CreatedDate = DateTime.Now
                });
            }

        }

        public void SeedGeometryResults()
        {
            if (!dbContext.GeometryResults.Any())
            {
                dbContext.GeometryResults.Add(new GeometryResult()
                {

                    Shape = dbContext.Shapes.FirstOrDefault(s => s.TypeOfShape == Convert.ToString(Shape.shape.Rectangle)),
                    Input1 = 30,
                    Input2 = 40,
                    Input3 = 0,
                    Perimeter = (2 * 30) + (2 * 40),
                    Area = 30 * 40,
                    DateOfGeometryResult = DateTime.Now,
                    IsActive = true
                });
                dbContext.GeometryResults.Add(new GeometryResult()
                {

                    Shape = dbContext.Shapes.FirstOrDefault(s => s.TypeOfShape == Convert.ToString(Shape.shape.Parallelogram)),
                    Input1 = 15,
                    Input2 = 24,
                    Input3 = 0,
                    Perimeter = (2 * 15) + (2 * 24),
                    Area = 15 * 24,
                    DateOfGeometryResult = DateTime.Now,
                    IsActive = true
                });
                dbContext.GeometryResults.Add(new GeometryResult()
                {

                    Shape = dbContext.Shapes.FirstOrDefault(s => s.TypeOfShape == Convert.ToString(Shape.shape.Triangle)),
                    Input1 = 15,
                    Input2 = 24,
                    Input3 = 30,
                    Perimeter = 15 + 24 + 30,
                    Area = 178.29,
                    DateOfGeometryResult = DateTime.Now,
                    IsActive = true
                });

                dbContext.GeometryResults.Add(new GeometryResult()
                {

                    Shape = dbContext.Shapes.FirstOrDefault(s => s.TypeOfShape == Convert.ToString(Shape.shape.Rhombus)),
                    Input1 = 9,
                    Input2 = 32,
                    Input3 = 0,
                    Perimeter = 4 * 9,
                    Area = 9 * 32,
                    DateOfGeometryResult = DateTime.Now,
                    IsActive = true
                });


            }




        }




    }
}
