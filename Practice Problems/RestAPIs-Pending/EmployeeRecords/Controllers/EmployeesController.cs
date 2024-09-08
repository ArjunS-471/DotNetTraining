using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeRecords.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public EmployeesController(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewEmployee>>> GetNewEmployees()
        {
            if (_context.NewEmployees == null)
            {
                return NotFound();
            }
            return await _context.NewEmployees.ToListAsync();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewEmployee>> GetNewEmployee(int id)
        {
            if (_context.NewEmployees == null)
            {
                return NotFound();
            }
            var NewEmployee = await _context.NewEmployees.FindAsync(id);

            if (NewEmployee == null)
            {
                return NotFound();
            }

            return NewEmployee;
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewEmployee(int id, NewEmployee NewEmployee)
        {
            if (id != NewEmployee.Id)
            {
                return BadRequest();
            }

            _context.Entry(NewEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewEmployeeExists(id))
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

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NewEmployee>> PostNewEmployee(NewEmployee NewEmployee)
        {
            if (_context.NewEmployees == null)
            {
                return Problem("Entity set 'EmployeeDbContext.NewEmployees'  is null.");
            }
            _context.NewEmployees.Add(NewEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewEmployee", new { id = NewEmployee.Id }, NewEmployee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewEmployee(int id)
        {
            if (_context.NewEmployees == null)
            {
                return NotFound();
            }
            var NewEmployee = await _context.NewEmployees.FindAsync(id);
            if (NewEmployee == null)
            {
                return NotFound();
            }

            _context.NewEmployees.Remove(NewEmployee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NewEmployeeExists(int id)
        {
            return (_context.NewEmployees?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

