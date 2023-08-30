using CarStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStore.AppContext
{
    public class CarContext : DbContext
    { 

        public DbSet<Car> Cars { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO брать строку подключения из appsettings.json
            optionsBuilder.UseSqlite("Data Source=CarStoreDB.db");
        }
    }
}
