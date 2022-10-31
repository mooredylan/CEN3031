using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Budgetting.Models;

namespace Budgetting.Data
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:uf.database.windows.net,1433;Initial Catalog=CEN3031-DB;Persist Security Info=False;User ID=budgetapp;Password=UF1234567890!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Budget> Budgets { get; set;}
        public DbSet<Profile> Profiles { get; set; } 
    }
}
