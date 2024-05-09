using Microsoft.EntityFrameworkCore;
using System.IO;
using EcoPocket.Models;
using Microsoft.Maui.Storage;
using Microsoft.Extensions.Options;
using System.Data.Common;
using EcoPocket.Utility;
using System.Security.AccessControl;

namespace EcoPocket.Data
{
    public class EcoPocketDbContextBase : DbContext
    {
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<IncomeCategory> IncomeCategory { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Account> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder vpOptionsBuilder)
        {
            // Now, configure the DbContext to use SQLite with the full path of the database.
            string vlDataBasePath = EcoPocket.Utility.DbConnection.GetRoute("EcoPocketDB.db");

            vpOptionsBuilder.UseSqlite($"Filename={vlDataBasePath}");

            // To export
            //string vlExternalStoragePath = FileSystem.AppDataDirectory;
            //string vlExportPath = Path.Combine(vlExternalStoragePath, "Exported_EcoPocketDB.db");
            //ExportDataBase(vlDataBasePath, vlExportPath).GetAwaiter();
        }     

        /// <summary>
        /// To export data base cache directory. MAY NOT USE WHEN THE CODE IS IN PRODUCTION
        /// </summary>
        /// <param name="vpDataBasePath">Data base path</param>
        /// <param name="vpExportPath">Export file path</param>
        private async Task ExportDataBase(string vpDataBasePath, string vpExportPath)
        {
            if (File.Exists(vpDataBasePath))
            {
                // Ensure the directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(vpExportPath));
                File.Copy(vpDataBasePath, vpExportPath, true);

                // Optionally share the file, Task
                await Share.RequestAsync(new ShareFileRequest
                {
                    Title = "Export Database",
                    File = new ShareFile(vpExportPath)
                });
            }
        }

    }
}