using System;
using Microsoft.EntityFrameworkCore;
using NotMe.Models;

namespace NotMe.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> User { get; set; }
        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<Label> Label { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
