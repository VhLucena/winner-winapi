
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public  ActionResult<List<PersonAbstract>> GetAllPersons()
        {
            return _personService.GetAll();
        }
        
        
        // CREATE: winapi/person
        [HttpPost] 
        public int CreatePerson(PersonAbstract person)
        {
            try
            {
                _personService.Create(person);
            }
            catch (Exception)
            {
                return StatusCodes.Status400BadRequest;
            }
            
            return StatusCodes.Status201Created;
        }
    }
}