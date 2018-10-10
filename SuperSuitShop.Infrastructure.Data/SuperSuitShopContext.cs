using Microsoft.EntityFrameworkCore;
using SuperSuitShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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

            public DbSet<SuperSuit> superSuits { get; set; }
        }
    
}
