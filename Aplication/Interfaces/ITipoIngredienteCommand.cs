using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface ITipoIngredienteCommand
    {
        Task<TipoIngrediente> Insert(TipoIngrediente tipoIngrediente);
        Task<TipoIngrediente> Remove(int tipoIngredienteId);
        Task<TipoIngrediente> Update(TipoIngrediente tipoIngrediente);
    }
}
