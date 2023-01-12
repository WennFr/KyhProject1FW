using MainMenuApp.Data;
using Microsoft.EntityFrameworkCore;

namespace MainMenuApp.Interfaces
{
    public interface IDbContext 
    { 
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<GeometricResult> GeometricResults { get; set; }
        public DbSet<CalculationResult> CalculationResults { get; set; }
        public DbSet<GameResult> GameResults { get; set; }
        public int SaveChanges();
    }
}
