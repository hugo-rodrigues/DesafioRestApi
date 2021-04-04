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
    public class EscolaController : ControllerBase
    {
     
        private readonly ILogger<EscolaController> _logger;

        private IEscolaBusiness _escolaBusiness;
 

        public EscolaController(ILogger<EscolaController> logger,  IEscolaBusiness escolaBusiness)
        {
            _logger = logger;
            _escolaBusiness = escolaBusiness;
        }

        [HttpGet("{id}")]
       public IActionResult Get(long id)
        {
            var person = _escolaBusiness.FindById(id);

            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_escolaBusiness.FindAll());
        }


       
        [HttpPost]    
        public IActionResult Post([FromBody] Escola escola)
        {
            if (escola == null) return BadRequest();
            return new ObjectResult(_escolaBusiness.Create(escola));
        }

     
        [HttpPut]    
        public IActionResult Put([FromBody] Escola escola)
        {
            if (escola == null) return BadRequest();
            return new ObjectResult(_escolaBusiness.Update(escola));
        }

     
        [HttpDelete("{id}")]   
        public IActionResult Delete(long id)
        {
            _escolaBusiness.Delete(id);
            return NoContent();
        }


        [HttpGet("MediaDosAlunosPorTurma/{id}")]
       // [Authorize(Roles = "Escola,Turma")]
        public IActionResult GetMediaDosAlunosPorTurma( long id)
        {
            return Ok(_escolaBusiness.MediaDosAlunosPorTurma(id));
        }

        [HttpGet("GetListaDosAlunosPorTurma/{id}")]
        [EnableQuery]
       // [Authorize(Roles = "Escola,Turma")]
        public IActionResult GetListaDosAlunosPorTurma(long id)
        {
            return Ok(_escolaBusiness.ListaDosAlunosPorTurma(id));
        }
    }
}
