using Aplication.Interfaces;
using Aplication.Response;
using Application.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioIngredientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIngredienteController : ControllerBase
    {
        private readonly ITipoIngredienteService _service;

        public TipoIngredienteController(ITipoIngredienteService service)
        {
            _service = service;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(TipoIngredienteResponse), 200)]
        [ProducesResponseType(typeof(BadRequest), 400)]
        public IActionResult GetByTipoIngrediente(int id)
        {
            try
            {
                var result = _service.GetByTipoIngrediente(id);
                return new JsonResult(result);
            }

            catch (BadRequestException ex)
            { return new JsonResult(new BadRequest { Message = ex.Message }) { StatusCode = 400 }; }
        }
    }
}
