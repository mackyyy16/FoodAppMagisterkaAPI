using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarsztatApi.Entities;
using WarsztatAPI.Entities;

namespace WarsztatAPI.DBContexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {               

        }

        public DbSet<User> user { get; set; }
        public DbSet<Meal> meal { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Restaurant> restaurant { get; set; }
        public DbSet<Category> category { get; set; }
    }
}
