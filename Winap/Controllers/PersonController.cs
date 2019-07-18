
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Winap.Exceptions;
using Winap.Models;
using Winap.Services;

namespace Winap.Controllers
{
    [Route("winapi/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _personService;

        public PersonController(PersonService personService)
        {
            _personService = personService;
        }
        
        // GET: winapi/person/all
        [HttpGet("all")]
        public  ActionResult<List<Person>> GetPersons()
        {
            return _personService.GetAllPersons();
        }

        // GET: winapi/{id}
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException("The ID must be equal or greater than zero.");
            }

            return _personService.GetById(id);
        }
    }
}