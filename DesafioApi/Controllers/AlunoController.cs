using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioApi.Business;
using DesafioApi.Model;

namespace DesafioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
     
        private readonly ILogger<AlunoController> _logger;
        private IAlunoBusiness _alunoBusiness;


        public AlunoController(ILogger<AlunoController> logger, IAlunoBusiness alunoBusiness)
        {
            _logger = logger;
           _alunoBusiness = alunoBusiness;
        }

        [HttpGet("{id}")]
       public IActionResult Get(long id)
        {
            var person = _alunoBusiness.FindById(id);

            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_alunoBusiness.FindAll());
        }


       
        [HttpPost]    
        public IActionResult Post([FromBody] Aluno aluno)
        {
            if (aluno == null) return BadRequest();
            return new ObjectResult(_alunoBusiness.Create(aluno));
        }

     
        [HttpPut]    
        public IActionResult Put([FromBody] Aluno aluno)
        {
            if (aluno == null) return BadRequest();
            return new ObjectResult(_alunoBusiness.Update(aluno));
        }

     
        [HttpDelete("{id}")]   
        public IActionResult Delete(long id)
        {
            _alunoBusiness.Delete(id);
            return NoContent();
        }
    }
}
