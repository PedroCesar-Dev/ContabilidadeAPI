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
    public class Clientes : ControllerBase
    {
        private readonly db_ConFinContext _context;

        public Clientes(db_ConFinContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<TbCliente>>> GetTbClientes()
        {
          if (_context.TbClientes == null)
          {
              return NotFound();
          }
            return await _context.TbClientes.ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<TbCliente>> GetTbCliente(int id)
        {
          if (_context.TbClientes == null)
          {
              return NotFound();
          }
            var tbCliente = await _context.TbClientes.FindAsync(id);

            if (tbCliente == null)
            {
                return NotFound();
            }

            return tbCliente;
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutTbCliente(int id, TbCliente tbCliente)
        {
            if (id != tbCliente.IdCliente)
            {
                return BadRequest();
            }

            _context.Entry(tbCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbClienteExists(id))
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

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<TbCliente>> PostTbCliente(TbCliente tbCliente)
        {
          if (_context.TbClientes == null)
          {
              return Problem("Entity set 'db_ConFinContext.TbClientes'  is null.");
          }
            _context.TbClientes.Add(tbCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbCliente", new { id = tbCliente.IdCliente }, tbCliente);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteTbCliente(int id)
        {
            if (_context.TbClientes == null)
            {
                return NotFound();
            }
            var tbCliente = await _context.TbClientes.FindAsync(id);
            if (tbCliente == null)
            {
                return NotFound();
            }

            _context.TbClientes.Remove(tbCliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbClienteExists(int id)
        {
            return (_context.TbClientes?.Any(e => e.IdCliente == id)).GetValueOrDefault();
        }
    }
}
