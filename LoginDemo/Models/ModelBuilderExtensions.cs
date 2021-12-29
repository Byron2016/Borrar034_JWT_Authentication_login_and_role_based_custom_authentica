using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTest>(entity =>
            {
                entity.HasData(
                    new UserTest
                    {
                        Id = 1,
                        Name = "a",
                        Email = "a.yahoo.com",
                        Password = "b"
                    },
                    new UserTest
                    {
                        Id = 2,
                        Name = "a2",
                        Email = "a2.yahoo.com",
                        Password = "b2"
                    }
                    );
            });
        }
    }
}
