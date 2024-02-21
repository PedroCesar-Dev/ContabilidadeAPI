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
    public class Empresas : ControllerBase
    {
        private readonly db_ConFinContext _context;

        public Empresas(db_ConFinContext context)
        {
            _context = context;
        }

        // GET: api/Empresas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbEmpresa>>> GetTbEmpresas()
        {
          if (_context.TbEmpresas == null)
          {
              return NotFound();
          }
            return await _context.TbEmpresas.ToListAsync();
        }

        // GET: api/Empresas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbEmpresa>> GetTbEmpresa(int id)
        {
          if (_context.TbEmpresas == null)
          {
              return NotFound();
          }
            var tbEmpresa = await _context.TbEmpresas.FindAsync(id);

            if (tbEmpresa == null)
            {
                return NotFound();
            }

            return tbEmpresa;
        }

        // PUT: api/Empresas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbEmpresa(int id, TbEmpresa tbEmpresa)
        {
            if (id != tbEmpresa.IdEmpresa)
            {
                return BadRequest();
            }

            _context.Entry(tbEmpresa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbEmpresaExists(id))
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

        // POST: api/Empresas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbEmpresa>> PostTbEmpresa(TbEmpresa tbEmpresa)
        {
          if (_context.TbEmpresas == null)
          {
              return Problem("Entity set 'db_ConFinContext.TbEmpresas'  is null.");
          }
            _context.TbEmpresas.Add(tbEmpresa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbEmpresa", new { id = tbEmpresa.IdEmpresa }, tbEmpresa);
        }

        // DELETE: api/Empresas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbEmpresa(int id)
        {
            if (_context.TbEmpresas == null)
            {
                return NotFound();
            }
            var tbEmpresa = await _context.TbEmpresas.FindAsync(id);
            if (tbEmpresa == null)
            {
                return NotFound();
            }

            _context.TbEmpresas.Remove(tbEmpresa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbEmpresaExists(int id)
        {
            return (_context.TbEmpresas?.Any(e => e.IdEmpresa == id)).GetValueOrDefault();
        }
    }
}
