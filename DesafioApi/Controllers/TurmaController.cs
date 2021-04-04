using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioApi.Business;
using DesafioApi.Model;
using Microsoft.AspNetCore.Authorization;
using System.Web.Http.OData;

namespace DesafioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {

        private readonly ILogger<TurmaController> _logger;
        private ITurmaBusiness _turmaBusiness;

        public TurmaController(ILogger<TurmaController> logger, ITurmaBusiness turmaBusiness)
        {
            _logger = logger;
            _turmaBusiness = turmaBusiness;

        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _turmaBusiness.FindById(id);

            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_turmaBusiness.FindAll());
        }

        [HttpGet("MediaDosAlunosPorTurma/{id}")]
       // [Authorize(Roles = "Escola,Turma")]
        public IActionResult GetMediaDosAlunosPorTurma(long id)
        {
            return Ok(_turmaBusiness.MediaDosAlunosPorTurma(id));
           
        }

        [HttpGet("ListaDosAlunosPorTurma/{id}")]
        [EnableQuery]
       // [Authorize(Roles = "Escola,Turma")]
        public IActionResult GetListaDosAlunosPorTurma( long id)
        {
            return Ok(_turmaBusiness.ListaDosAlunosPorTurma(id));
        }

        [HttpPost]    
        public IActionResult Post([FromBody] Turma turma)
        {
            if (turma == null) return BadRequest();
            return new ObjectResult(_turmaBusiness.Create(turma));
        }

     
        [HttpPut]    
        public IActionResult Put([FromBody] Turma turma)
        {
            if (turma == null) return BadRequest();
            return new ObjectResult(_turmaBusiness.Update(turma));
        }

     
        [HttpDelete("{id}")]   
        public IActionResult Delete(long id)
        {
            _turmaBusiness.Delete(id);
            return NoContent();
        }
    }
}
