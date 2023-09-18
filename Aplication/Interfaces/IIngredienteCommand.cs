using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface IIngredienteCommand
    {
        Task<Ingrediente> Insert(Ingrediente ingrediente);
        Task<Ingrediente> Remove(int ingredienteId);
        Task<Ingrediente> Update(Ingrediente ingrediente, Ingrediente ingredienteUpdate);
    }
}
