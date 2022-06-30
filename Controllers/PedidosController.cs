using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendChallenge.Data;
using BackendChallenge.Models;

namespace BackendChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public PedidoController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Pedido
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedido()
        {
            return await _context.Pedidos.ToListAsync();
        }

        // GET: api/Pedido/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var Pedido = await _context.Pedidos.FindAsync(id);

            if (Pedido == null)
            {
                return NotFound();
            }

            return Pedido;
        }

        // PUT: api/Pedido/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, Pedido Pedido)
        {
            if (id != Pedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(Pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
                /*
                if (!PedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }*/
            }

            return NoContent();
        }

        // POST: api/Pedido
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido Pedido)
        {
            _context.Pedidos.Add(Pedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedido", new { id = Pedido.Id }, Pedido);

        }

        // DELETE: api/Pedido/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            var Pedido = await _context.Pedidos.FindAsync(id);
            if (Pedido == null)
            {
                return NotFound();
            }

            _context.Pedidos.Remove(Pedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
