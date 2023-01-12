﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenuApp.Data;

namespace MainMenuApp.Menus.Data
{
    public class Builder
    {
        private static DbContextOptionsBuilder<ApplicationDbContext> options;

        public static void BuildDatabase()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();

            options = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);
        }

        public static ApplicationDbContext InitializeData()
        {
            using (var dbContext = new ApplicationDbContext(options.Options))
            {
                var dataInitializer = new DataInitializer(dbContext);
                dataInitializer.Migrate();
                dataInitializer.Seed();

                var dbContextReturned = new ApplicationDbContext(options.Options);
                return dbContextReturned;
            }

        }

    }
}
