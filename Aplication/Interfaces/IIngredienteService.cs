using Aplication.Models;
using Aplication.Response;

namespace Aplication.Interfaces
{
    public interface IIngredienteService
    {
        Task<IngredienteResponse> CreateIngrediente(IngredienteRequest request);
        IngredienteResponse GetById(int id);
        List<IngredienteResponse> GetByName(string name);
    }
}
