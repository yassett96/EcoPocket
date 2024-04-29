using Microsoft.EntityFrameworkCore;

namespace EcoPocket.Data
{
    internal class EcoPocketDbContextBase : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=");
        }
    }
}