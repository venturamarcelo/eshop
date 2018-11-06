using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace storeStation.Models
{
    public class StationContext : DbContext
    {
        public StationContext (DbContextOptions<StationContext> options)
            : base(options)
        {
        }

        public DbSet<storeStation.Models.Product> Products { get; set; }
        DbSet<storeStation.Models.Transaction> Transactions { get; set; }
        
    }
}
