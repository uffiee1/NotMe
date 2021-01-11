using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NotMe.Models;

namespace NotMe.DataAccess
{
    public class AppDbContext : ApiAuthorizationDbContext<User>
    {
        public AppDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
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
