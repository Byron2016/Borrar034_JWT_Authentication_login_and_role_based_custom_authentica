using LoginDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<UserTest> UserTests { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserTest>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
                //entity.HasData(
                //    new UserTest
                //    {
                //        Id = 1,
                //        Name = "a",
                //        Email = "a.yahoo.com",
                //        Password = "b"
                //    }
                //    );
            });
            modelBuilder.Seed();
        }
    }
}
