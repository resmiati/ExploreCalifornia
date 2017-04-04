using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class SpecialsDataContext : DbContext
    {
        public DbSet<Special> Specials { get; set; }

        public SpecialsDataContext(DbContextOptions<SpecialsDataContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public IEnumerable<Special> GetMonthlySpecials()
        {
            return Specials.ToArray();
        }

    }
}
