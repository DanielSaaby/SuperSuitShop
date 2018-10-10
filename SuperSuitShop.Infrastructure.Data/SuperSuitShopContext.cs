using Microsoft.EntityFrameworkCore;
using SuperSuitShop.Core.Entities;

namespace SuperSuitShop.Infrastructure.Data
{
    
        public class SuperSuitShopContext : DbContext
        {
            public SuperSuitShopContext(DbContextOptions<SuperSuitShopContext> opt) : base(opt)
            {
                //Constructor to Super Class
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //Write Relations between models
            }

            public DbSet<SuperSuit> SuperSuits { get; set; }
        }
    
}
