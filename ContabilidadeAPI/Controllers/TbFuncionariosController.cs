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
    public class TbFuncionariosController : ControllerBase
    {
        private readonly db_ConFinContext _context;

        public TbFuncionariosController(db_ConFinContext context)
        {
            _context = context;
        }

        // GET: api/TbFuncionarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbFuncionario>>> GetTbFuncionarios()
        {
          if (_context.TbFuncionarios == null)
          {
              return NotFound();
          }
            return await _context.TbFuncionarios.ToListAsync();
        }

        // GET: api/TbFuncionarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbFuncionario>> GetTbFuncionario(int id)
        {
          if (_context.TbFuncionarios == null)
          {
              return NotFound();
          }
            var tbFuncionario = await _context.TbFuncionarios.FindAsync(id);

            if (tbFuncionario == null)
            {
                return NotFound();
            }

            return tbFuncionario;
        }

        // PUT: api/TbFuncionarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbFuncionario(int id, TbFuncionario tbFuncionario)
        {
            if (id != tbFuncionario.IdFuncionario)
            {
                return BadRequest();
            }

            _context.Entry(tbFuncionario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbFuncionarioExists(id))
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

        // POST: api/TbFuncionarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbFuncionario>> PostTbFuncionario(TbFuncionario tbFuncionario)
        {
          if (_context.TbFuncionarios == null)
          {
              return Problem("Entity set 'db_ConFinContext.TbFuncionarios'  is null.");
          }
            _context.TbFuncionarios.Add(tbFuncionario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbFuncionario", new { id = tbFuncionario.IdFuncionario }, tbFuncionario);
        }

        // DELETE: api/TbFuncionarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbFuncionario(int id)
        {
            if (_context.TbFuncionarios == null)
            {
                return NotFound();
            }
            var tbFuncionario = await _context.TbFuncionarios.FindAsync(id);
            if (tbFuncionario == null)
            {
                return NotFound();
            }

            _context.TbFuncionarios.Remove(tbFuncionario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbFuncionarioExists(int id)
        {
            return (_context.TbFuncionarios?.Any(e => e.IdFuncionario == id)).GetValueOrDefault();
        }
    }
}
