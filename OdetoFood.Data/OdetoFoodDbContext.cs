using System;
using Microsoft.EntityFrameworkCore;
using OdetoFood.Core;
using OdeToFood.Core;

namespace OdetoFood.Data
   
{
   public class OdetoFoodDbContext : DbContext
    {
        public OdetoFoodDbContext(DbContextOptions<OdetoFoodDbContext>options)
            : base(options)
        {

        }

    public DbSet<Restaurant> Restaurants { get; set; }
    }
}
