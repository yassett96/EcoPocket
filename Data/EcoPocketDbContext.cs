using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPocket.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoPocket.Data
{
    /// <summary>
    /// Data base conext EcoPocket
    /// </summary>
    internal class EcoPocketDbContext : DbContext
    {
        public DbSet<Expenses>? Expenses { get; set; }
        public DbSet<ExpensesCategories>? ExpensesCategories { get; set; }
        public DbSet<Incomes>? Incomes { get; set; }
        public DbSet<IncomesCategories>? IncomesCategories { get; set; }
        public DbSet<PaymentMethods>? PaymentMethods { get; set; }
        public DbSet<Source>? Source { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder vpOptionsBuilder)
        {
            string vlFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string vlDatabasePath = Path.Combine(vlFolder, "EcoPocketDB.db");
            vpOptionsBuilder.UseSqlite($"Filename={vlDatabasePath}");
            vpOptionsBuilder.UseSqlite("Filename=");
        }
    }
}
