using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasWeightApp.Entities
{
    public class Exercises
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public char Private { get; set; }
        public List<HasCategories> hasCategories { get; set; }

    }
}
