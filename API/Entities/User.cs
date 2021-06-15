using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasWeightApp.Entities
{
    public class User 
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Gender { get; set; }
        public string PhoneNumber { get; set; }

    }
}
