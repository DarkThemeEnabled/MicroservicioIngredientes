using Aplication.Interfaces;
using Aplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioIngredientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : Controller
    {
        private readonly IIngredienteService _service;

        public IngredienteController(IIngredienteService service)
        {
            _service = service;
        }

        [HttpGet("{Id}")]
        public IActionResult GetByID(int Id)
        {
            var result = _service.GetByID(Id);
            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIngrediente(IngredienteRequest request)
        {
            var result = await _service.CreateIngrediente(request);
            return new JsonResult(result) { StatusCode = 201 };
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteIngredientn(int Id)
        {
            var result = await _service.DeleteIngrediente(Id);
            return new JsonResult(result);
        }
        [HttpPatch("{Id}")]
        public async Task<IActionResult> UpdateIngredient(int Id, IngredienteRequest request)
        {
            var result = await _service.UpdateIngrediente(Id, request);
            return new JsonResult(result);
        }
    }
}
