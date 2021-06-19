using AtlasWeightApp.Data;
using AtlasWeightApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasWeightApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly WeightDbClass _context;

        public ExerciseController(WeightDbClass context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Exercises>>> GetAllExercises()
        {
            return await _context.Exercises.ToListAsync();
        }
    }
}
