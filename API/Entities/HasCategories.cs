using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasWeightApp.Entities
{
    public class HasCategories
    {
        [Key]
        public int Id { get; set; }
        public int ExercisesId { get; set; }
        public Exercises Exercises { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
