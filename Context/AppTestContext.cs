using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Context
{
    public class AppTestContext : DbContext
    {
        public AppTestContext(DbContextOptions<AppTestContext> options) : base(options) { }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Ids> Ids { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>().HasKey(c => new { c.Identification });
            modelBuilder.Entity<Ids>().HasKey(c => new { c.Identification });
        }
    }
}
