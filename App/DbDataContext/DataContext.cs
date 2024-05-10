using MacroApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroApp.DbDataContext
{
    internal class DataContext : DbContext
    {
        public DbSet<Operator> Operators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        => option.UseSqlite("Data Source=macroapp.db");
    }
}
