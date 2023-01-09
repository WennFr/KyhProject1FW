using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Data
{
    public class DataInitializer
    {
        public ApplicationDbContext dbContext { get; set; }

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
    }
}
