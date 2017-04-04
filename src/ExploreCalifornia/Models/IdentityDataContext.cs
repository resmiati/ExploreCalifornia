using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    //public class ApplicationUser : IdentityUser
    //{

    //}

    public class IdentityDataContext : IdentityDbContext<IdentityUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            //builder.Entity<IdentityUserRole>().ToTable("UserRoles");
            //builder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            //builder.Entity<IdentityUserLogin>().ToTable("UserLogins");
        }
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        
    }
}
