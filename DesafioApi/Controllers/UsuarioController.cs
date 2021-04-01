using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioApi.Business;

namespace DesafioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
     
        private readonly ILogger<PersonController> _logger;
        private IUsuarioBusiness _usuarioBusiness;

        public PersonController(ILogger<PersonController> logger, IUsuarioBusiness usuarioBusiness)
        {
            _logger = logger;
            _usuarioBusiness = usuarioBusiness;
        }

        [HttpGet("{id}")]
       public IActionResult Get(long id)
        {
            var person = _usuarioBusiness.FindById(id);

            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpGet]
        public IActionResult Get()
        {
            

           
            return Ok(_usuarioBusiness.FindAll());
        }
    }
}
