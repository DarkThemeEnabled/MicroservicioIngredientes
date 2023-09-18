using Aplication.Models;
using Aplication.Response;
using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface IIngredienteService
    {
        Task<IngredienteResponse> CreateIngrediente(IngredienteRequest request);
        Task<IngredienteResponse> UpdateIngrediente(int ingredienteID, IngredienteRequest request);
        Task<IngredienteResponse> DeleteIngrediente(int ingredientId);
        List<Ingrediente> GetAll();
        IngredienteResponse GetByID(int ingredienteId);
    }
}
