using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Data;

namespace ServiceLibrary.Interfaces
{
    public interface IDbContext 
    { 
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<GeometryResult> GeometryResults { get; set; }
        public DbSet<CalculationResult> CalculationResults { get; set; }
        public DbSet<GameResult> GameResults { get; set; }
        public int SaveChanges();
    }
}
