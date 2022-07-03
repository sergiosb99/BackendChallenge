using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendChallenge.Data;
using BackendChallenge.Models;
using System.Diagnostics;

namespace BackendChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialesController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public HistorialesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Historiales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Historial>>> GetHistoriales()
        {
            return await _context.Historiales.ToListAsync();
        }

        // GET: api/Historiales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Historial>> GetHistorial(int id)
        {
            var Historial = await _context.Historiales.FindAsync(id);

            if (Historial == null)
            {
                return NotFound();
            }

            return Historial;
        }

        // GET: api/Historiales/Vehiculo/{id}
        [HttpGet("Vehiculo/{id}")]
        public List<Historial> GetHistorialVehiculo(int id)
        {
            var Historiales = _context.Historiales;
            List<Historial> Historiales_vehiculo = new List<Historial>();

            foreach (Historial Historial in Historiales)
            {
                if (Historial.VehiculoId == id)
                {
                    Historiales_vehiculo.Add(Historial);
                }
            }

            return Historiales_vehiculo;
        }

        // PUT: api/Historiales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistorial(int id, Historial Historial)
        {
            if (id != Historial.Id)
            {
                return BadRequest();
            }

            _context.Entry(Historial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Historiales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Historial>> PostHistorial(Historial Historial)
        {
            _context.Historiales.Add(Historial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistorial", new { id = Historial.Id }, Historial);

        }

        // DELETE: api/Historiales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistorial(int id)
        {
            var Historial = await _context.Historiales.FindAsync(id);
            if (Historial == null)
            {
                return NotFound();
            }

            _context.Historiales.Remove(Historial);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
