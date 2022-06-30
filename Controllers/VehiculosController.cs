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
    public class VehiculosController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public VehiculosController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Vehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculos()
        {
            return await _context.Vehiculos.ToListAsync();
        }

        // GET: api/Vehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculo(int id)
        {
            var Vehiculo = await _context.Vehiculos.FindAsync(id);

            if (Vehiculo == null)
            {
                return NotFound();
            }

            return Vehiculo;
        }

        // PUT: api/Vehiculos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculo(int id, Vehiculo Vehiculo)
        {
            if (id != Vehiculo.Id)
            {
                return BadRequest();
            }

            _context.Entry(Vehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
                /*
                if (!VehiculoExists(id))
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

        // POST: api/Vehiculos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehiculo>> PostVehiculo(Vehiculo Vehiculo)
        {
            _context.Vehiculos.Add(Vehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiculo", new { id = Vehiculo.Id }, Vehiculo);

        }

        // DELETE: api/Vehiculos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculo(int id)
        {
            var Vehiculo = await _context.Vehiculos.FindAsync(id);
            if (Vehiculo == null)
            {
                return NotFound();
            }

            _context.Vehiculos.Remove(Vehiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}