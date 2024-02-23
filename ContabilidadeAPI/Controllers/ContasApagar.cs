using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContabilidadeAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace ContabilidadeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasApagar : ControllerBase
    {
        private readonly db_ConFinContext _context;

        public ContasApagar(db_ConFinContext context)
        {
            _context = context;
        }

        // GET: api/ContasApagar
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<TbContasAPagar>>> GetTbContasAPagars()
        {
          if (_context.TbContasAPagars == null)
          {
              return NotFound();
          }
            return await _context.TbContasAPagars.ToListAsync();
        }

        // GET: api/ContasApagar/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<TbContasAPagar>> GetTbContasAPagar(int id)
        {
          if (_context.TbContasAPagars == null)
          {
              return NotFound();
          }
            var tbContasAPagar = await _context.TbContasAPagars.FindAsync(id);

            if (tbContasAPagar == null)
            {
                return NotFound();
            }

            return tbContasAPagar;
        }

        // PUT: api/ContasApagar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutTbContasAPagar(int id, TbContasAPagar tbContasAPagar)
        {
            if (id != tbContasAPagar.IdContas)
            {
                return BadRequest();
            }

            _context.Entry(tbContasAPagar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbContasAPagarExists(id))
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

        // POST: api/ContasApagar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<TbContasAPagar>> PostTbContasAPagar(TbContasAPagar tbContasAPagar)
        {
          if (_context.TbContasAPagars == null)
          {
              return Problem("Entity set 'db_ConFinContext.TbContasAPagars'  is null.");
          }
            _context.TbContasAPagars.Add(tbContasAPagar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbContasAPagar", new { id = tbContasAPagar.IdContas }, tbContasAPagar);
        }

        // DELETE: api/ContasApagar/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteTbContasAPagar(int id)
        {
            if (_context.TbContasAPagars == null)
            {
                return NotFound();
            }
            var tbContasAPagar = await _context.TbContasAPagars.FindAsync(id);
            if (tbContasAPagar == null)
            {
                return NotFound();
            }

            _context.TbContasAPagars.Remove(tbContasAPagar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbContasAPagarExists(int id)
        {
            return (_context.TbContasAPagars?.Any(e => e.IdContas == id)).GetValueOrDefault();
        }
    }
}
