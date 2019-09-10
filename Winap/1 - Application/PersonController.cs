
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Winap.Database;
using Winap.Exceptions;
using Winap.Models;
using Winap.Models.Interfaces;
using Winap.Services;

namespace Winap.Controllers
{
    [Route("winapi/[controller]")]
    [ApiController]
    public class PersonController : WinnerController<PersonAbstract>
    {
        private readonly IService<PersonAbstract> _personService;

        public PersonController(IService<PersonAbstract> personService)
        {
            _personService = personService;
        }
        
        // GET: winapi/person/all
        public override ActionResult<List<PersonAbstract>> GetAll()
        {
            return _personService.GetAll();
        }

        // CREATE: winapi/person
        public override int Create(PersonAbstract person)
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