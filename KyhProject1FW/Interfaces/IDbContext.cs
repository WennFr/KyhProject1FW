using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace KyhProject1FW.Interfaces
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
