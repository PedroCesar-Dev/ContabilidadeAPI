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
    public class Fornecedores : ControllerBase
    {
        private readonly db_ConFinContext _context;

        public Fornecedores(db_ConFinContext context)
        {
            _context = context;
        }

        // GET: api/Fornecedores
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<TbFornecedor>>> GetTbFornecedors()
        {
          if (_context.TbFornecedors == null)
          {
              return NotFound();
          }
            return await _context.TbFornecedors.ToListAsync();
        }

        // GET: api/Fornecedores/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<TbFornecedor>> GetTbFornecedor(int id)
        {
          if (_context.TbFornecedors == null)
          {
              return NotFound();
          }
            var tbFornecedor = await _context.TbFornecedors.FindAsync(id);

            if (tbFornecedor == null)
            {
                return NotFound();
            }

            return tbFornecedor;
        }

        // PUT: api/Fornecedores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutTbFornecedor(int id, TbFornecedor tbFornecedor)
        {
            if (id != tbFornecedor.IdFornecedor)
            {
                return BadRequest();
            }

            _context.Entry(tbFornecedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbFornecedorExists(id))
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

        // POST: api/Fornecedores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<TbFornecedor>> PostTbFornecedor(TbFornecedor tbFornecedor)
        {
          if (_context.TbFornecedors == null)
          {
              return Problem("Entity set 'db_ConFinContext.TbFornecedors'  is null.");
          }
            _context.TbFornecedors.Add(tbFornecedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbFornecedor", new { id = tbFornecedor.IdFornecedor }, tbFornecedor);
        }

        // DELETE: api/Fornecedores/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteTbFornecedor(int id)
        {
            if (_context.TbFornecedors == null)
            {
                return NotFound();
            }
            var tbFornecedor = await _context.TbFornecedors.FindAsync(id);
            if (tbFornecedor == null)
            {
                return NotFound();
            }

            _context.TbFornecedors.Remove(tbFornecedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbFornecedorExists(int id)
        {
            return (_context.TbFornecedors?.Any(e => e.IdFornecedor == id)).GetValueOrDefault();
        }
    }
}
