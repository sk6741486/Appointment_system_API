using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Appointment_system_API.Data;
using Appointment_system_API.model;

namespace Appointment_system_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tablesController : ControllerBase
    {
        private readonly Database _context;

        public tablesController(Database context)
        {
            _context = context;
        }

        // GET: api/tables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<table>>> Gettable()
        {
            return await _context.table.ToListAsync();
        }

        // GET: api/tables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<table>> Gettable(int id)
        {
            var table = await _context.table.FindAsync(id);

            if (table == null)
            {
                return NotFound();
            }

            return table;
        }

        // PUT: api/tables/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Puttable(int id, table table)
        {
            if (id != table.Id)
            {
                return BadRequest();
            }

            _context.Entry(table).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tableExists(id))
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

        // POST: api/tables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<table>> Posttable(table table)
        {
            _context.table.Add(table);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Gettable", new { id = table.Id }, table);
        }

        // DELETE: api/tables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletetable(int id)
        {
            var table = await _context.table.FindAsync(id);
            if (table == null)
            {
                return NotFound();
            }

            _context.table.Remove(table);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool tableExists(int id)
        {
            return _context.table.Any(e => e.Id == id);
        }
    }
}
