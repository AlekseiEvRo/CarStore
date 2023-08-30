using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.AppContext
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
