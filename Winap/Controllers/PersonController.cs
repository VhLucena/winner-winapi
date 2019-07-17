
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Winap.Exceptions;
using Winap.Models;

namespace Winap.Controllers
{
    [Route("winapi/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly WinapiContext _context;

        public PersonController(WinapiContext context)
        {
            _context = context;

            if (_context.Persons.Count() != 0) return;
            
            _context.Persons.Add(new Person {Name = "Beatriz Akemy", Age = 26});
            _context.SaveChanges();
        }
        
        // GET: winapi/all
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
        {
            return await _context.Persons.ToListAsync();
        }

        // GET: winapi/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException("The ID must be equal or greater than zero.");
            }
            
            var person = await _context.Persons.FindAsync(id);

            return person == null ? (ActionResult<Person>) NotFound() : person;
        }
    }
}