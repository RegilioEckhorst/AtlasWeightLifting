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
        public WeightDbClass(DbContextOptions<WeightDbClass> options) : base(options)
        {
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<HasCategories> HasCategories { get; set; }
        public DbSet<Exercises> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercises>().HasData(
                new Exercises { Id = 1, Name="Benchpress", Private = '1' },
                new Exercises { Id = 2, Name = "Dumbell press", Private = '0' },
                new Exercises { Id = 3, Name = "ThreadMill", Private = '1'},
                new Exercises { Id = 4, Name = "Rope skipping", Private = '1'},
                new Exercises { Id = 5, Name = "Bulgarian splitsquat"}
                );

            modelBuilder.Entity<Categories>().HasData(
                new Categories { Id = 1, Name="Cardio" },
                new Categories { Id = 2, Name = "Weightlifting"},
                new Categories { Id = 3, Name = "Crossfit" },
                new Categories { Id = 4, Name = "Revalidation"},
                new Categories { Id = 5, Name = "Other"}
                );

            modelBuilder.Entity<HasCategories>().HasData(
                //Benchpress
                new HasCategories { Id = 1, CategoriesId = 2, ExercisesId = 1},
                new HasCategories { Id = 2, CategoriesId = 3, ExercisesId = 1 },
               
                //Dumbell press
                new HasCategories { Id = 3, CategoriesId = 2, ExercisesId = 2 },
               
                //Threadmill
                new HasCategories { Id = 4, CategoriesId = 1, ExercisesId = 3 },
               
                //Rope skipping
                new HasCategories { Id = 5, CategoriesId = 1, ExercisesId = 4 },
                new HasCategories { Id = 6, CategoriesId = 3, ExercisesId = 4 },
                new HasCategories { Id = 7, CategoriesId = 4, ExercisesId = 4 },
                
                //BulgarianSplitSquat
                new HasCategories { Id = 8, CategoriesId = 2, ExercisesId = 5 },
                new HasCategories { Id = 9, CategoriesId = 3, ExercisesId = 5 },
                new HasCategories { Id = 10, CategoriesId = 4, ExercisesId = 5 }
                );
        }

    }
}
