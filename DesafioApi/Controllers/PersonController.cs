using System;
using System.Collections.Generic;
using DesafioApi.Services;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesafioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
     
        private readonly ILogger<PersonController> _logger;
        private IpersonService _personService;

        public PersonController(ILogger<PersonController> logger,IpersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet("{id}")]
       public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);

            if (person == null) return NotFound();
            return Ok(person);
        }



        [HttpPut]
        public IActionResult Put([Frombody] PersonController person)
        {
         

            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));
        }

        [HttpPost]
        public IActionResult Post([Frombody] PersonController person)
        {


            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {

            _personService.Delete(id);
            if (person == null) return NotFound();
            return NoContent();
        }
    }
}
