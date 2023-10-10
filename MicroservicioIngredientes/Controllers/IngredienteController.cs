using Aplication;
using Aplication.Interfaces;
using Aplication.Response;
using Application.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioIngredientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private readonly IIngredienteService _service;

        public IngredienteController(IIngredienteService service)
        {
            _service = service;
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(IngredienteResponse), 200)]
        [ProducesResponseType(typeof(BadRequest), 400)]
        public IActionResult GetByID(int Id)
        {
            try
            {
                var result = _service.GetById(Id);
                return new JsonResult(result);
            }

            catch (BadRequestException ex)
            { return new JsonResult(new BadRequest { Message = ex.Message }) { StatusCode = 400 }; }

        }

        [HttpGet("{Name}")]
        [ProducesResponseType(typeof(List<IngredienteResponse>), 200)]
        [ProducesResponseType(typeof(BadRequest), 400)]
        public IActionResult GetByName(string Name)
        {
            try
            {
                var result = _service.GetByName(Name);
                return new JsonResult(result);
            }

            catch (BadRequestException ex)
            { return new JsonResult(new BadRequest { Message = ex.Message }) { StatusCode = 400 }; }
        }
    }
}
