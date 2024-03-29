﻿using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Interfaces;

namespace ServiceLibrary.Data
{
    public class ApplicationDbContext : DbContext,IDbContext
    {

        public DbSet<Shape> Shapes { get; set; }
        public DbSet<GeometryResult> GeometryResults { get; set; }
        public DbSet<CalculationResult> CalculationResults { get; set; }
        public DbSet<GameResult> GameResults { get; set; }
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=Project1DatabaseFW;Trusted_Connection=True;TrustServerCertificate=true");
            }
        }




    }
}
