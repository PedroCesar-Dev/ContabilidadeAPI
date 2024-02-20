using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContabilidadeAPI.Models;

namespace ContabilidadeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TbContasARecebersController : ControllerBase
    {
        private readonly db_ConFinContext _context;

        public TbContasARecebersController(db_ConFinContext context)
        {
            _context = context;
        }

        // GET: api/TbContasARecebers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbContasAReceber>>> GetTbContasARecebers()
        {
          if (_context.TbContasARecebers == null)
          {
              return NotFound();
          }
            return await _context.TbContasARecebers.ToListAsync();
        }

        // GET: api/TbContasARecebers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbContasAReceber>> GetTbContasAReceber(int id)
        {
          if (_context.TbContasARecebers == null)
          {
              return NotFound();
          }
            var tbContasAReceber = await _context.TbContasARecebers.FindAsync(id);

            if (tbContasAReceber == null)
            {
                return NotFound();
            }

            return tbContasAReceber;
        }

        // PUT: api/TbContasARecebers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbContasAReceber(int id, TbContasAReceber tbContasAReceber)
        {
            if (id != tbContasAReceber.IdContas)
            {
                return BadRequest();
            }

            _context.Entry(tbContasAReceber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbContasAReceberExists(id))
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

        // POST: api/TbContasARecebers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbContasAReceber>> PostTbContasAReceber(TbContasAReceber tbContasAReceber)
        {
          if (_context.TbContasARecebers == null)
          {
              return Problem("Entity set 'db_ConFinContext.TbContasARecebers'  is null.");
          }
            _context.TbContasARecebers.Add(tbContasAReceber);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbContasAReceber", new { id = tbContasAReceber.IdContas }, tbContasAReceber);
        }

        // DELETE: api/TbContasARecebers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbContasAReceber(int id)
        {
            if (_context.TbContasARecebers == null)
            {
                return NotFound();
            }
            var tbContasAReceber = await _context.TbContasARecebers.FindAsync(id);
            if (tbContasAReceber == null)
            {
                return NotFound();
            }

            _context.TbContasARecebers.Remove(tbContasAReceber);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbContasAReceberExists(int id)
        {
            return (_context.TbContasARecebers?.Any(e => e.IdContas == id)).GetValueOrDefault();
        }
    }
}
