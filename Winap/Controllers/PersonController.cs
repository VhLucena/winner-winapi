
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Winap.Exceptions;
using Winap.Models;
using Winap.Models.Interfaces;
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

        // GET: winapi/person/{id}
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(Int32 id)
        {
            if (id < 0)
            {
                throw new InvalidIdException("The ID must be equal or greater than zero.");
            }

            return _personService.GetById(id);
        }
        
        // CREATE: winapi/person
        [HttpPost()] 
        public ActionResult<HttpStatusCode> CreatePerson(IPerson person)
        {
            _personService.Create(person);
            return HttpStatusCode.Created;
        }
    }
}