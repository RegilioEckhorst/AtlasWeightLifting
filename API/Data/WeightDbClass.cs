using AtlasWeightApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasWeightApp.Data
{
    public class WeightDbClass : DbContext
    {
        List<HasCategories> hasCategories = new List<HasCategories>();

        HasCategories hs = new HasCategories()
        {
            Id = 1,
            ExercisesId = 1,
            CategoriesId = 1
        };

        List<string> ck = new List<string>();
        
        

        public WeightDbClass(DbContextOptions<WeightDbClass> options) : base(options)
        {
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<HasCategories> HasCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            hasCategories.Add(hs);
            modelBuilder.Entity<Exercises>().HasData(
                new Exercises { Id = 1, Name="Benchpress", Private = '1' },
                new Exercises { Id = 2, Name = "Dumbell press", Private = '0' }
                );

            modelBuilder.Entity<Categories>().HasData(
                new Categories { Id = 1, Name="Cardio" },
                new Categories { Id = 2, Name = "Weight"}
                );

            modelBuilder.Entity<HasCategories>().HasData(
                new HasCategories { Id = 1, CategoriesId = 1, ExercisesId = 1},
                new HasCategories { Id = 2, CategoriesId = 2, ExercisesId = 1 }
                );
        }

    }
}
