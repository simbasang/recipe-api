using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using recipeApi.Models;

namespace recipeApi
{
    public class RecepieDbContext : DbContext
    {
        public DbSet<Recepies> Recepies { get; set; }
        public DbSet<Ingrediens> Ingrediens { get; set; }
        public DbSet<AmountType> AmountTypes { get; set; }
        public DbSet<RecepieIngrediens> RecepieIngrediens { get; set; }

        public RecepieDbContext(DbContextOptions<RecepieDbContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AmountType>().ToTable("AmountType");
            builder.Entity<AmountType>().HasKey(pk => pk.ID);
            builder.Entity<AmountType>().HasData(new
            {
                ID = 1,
                Name = "dl",
            },
            new
            {
                ID = 2,
                Name = "msk",
            },
            new
            {
                ID = 3,
                Name = "tsk",
            },
              new
              {
                  ID = 4,
                  Name = "gram",
              });
            base.OnModelCreating(builder);

        }

    }
}
