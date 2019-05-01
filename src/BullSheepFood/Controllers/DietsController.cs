using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BullSheepFood.Data;
using BullSheepFood.Models;

namespace BullSheepFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietsController : ControllerBase
    {
        private readonly BullSheepDbContext _context;

        public DietsController(BullSheepDbContext context)
        {
            _context = context;
        }

        // GET: api/Diets
        [HttpGet]
        public IEnumerable<Diet> GetDiets()
        {
            return _context.Diets;
        }

        // GET: api/Diets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var diet = await _context.Diets.FindAsync(id);

            if (diet == null)
            {
                return NotFound();
            }

            return Ok(diet);
        }

        // PUT: api/Diets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiet([FromRoute] int id, [FromBody] Diet diet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != diet.DietId)
            {
                return BadRequest();
            }

            _context.Entry(diet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DietExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Diets
        [HttpPost]
        public async Task<IActionResult> PostDiet([FromBody] Diet diet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Diets.Add(diet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDiet", new { id = diet.DietId }, diet);
        }

        // DELETE: api/Diets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var diet = await _context.Diets.FindAsync(id);
            if (diet == null)
            {
                return NotFound();
            }

            _context.Diets.Remove(diet);
            await _context.SaveChangesAsync();

            return Ok(diet);
        }

        private bool DietExists(int id)
        {
            return _context.Diets.Any(e => e.DietId == id);
        }
    }
}