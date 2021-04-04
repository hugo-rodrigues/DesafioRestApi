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
    public class UsuarioController : ControllerBase
    {
     
        private readonly ILogger<UsuarioController> _logger;
        private IUsuarioBusiness _usuarioBusiness;
        private IAlunoBusiness _alunoBusiness;
        private IEscolaBusiness _escolaBusiness;
        private ITurmaBusiness _turmaBusiness;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioBusiness usuarioBusiness, IAlunoBusiness alunoBusiness, IEscolaBusiness escolaBusiness, ITurmaBusiness turmaBusiness)
        {
            _logger = logger;
            _usuarioBusiness = usuarioBusiness;
            _turmaBusiness = turmaBusiness;
            _escolaBusiness = escolaBusiness;
           _alunoBusiness = alunoBusiness;
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


       
        [HttpPost]    
        public IActionResult Post([FromBody] Usuario usuario)
        {
            if (usuario == null) return BadRequest();
            return new ObjectResult(_usuarioBusiness.Create(usuario));
        }

     
        [HttpPut]    
        public IActionResult Put([FromBody] Usuario usuario)
        {
            if (usuario == null) return BadRequest();
            return new ObjectResult(_usuarioBusiness.Update(usuario));
        }

     
        [HttpDelete("{id}")]   
        public IActionResult Delete(long id)
        {
            _usuarioBusiness.Delete(id);
            return NoContent();
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Usuario usuario)
        {
          
            var user = _usuarioBusiness.FindById(usuario.Id);

           
            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

           
            var token = TokenService.GenerateToken(user);

          

           
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
