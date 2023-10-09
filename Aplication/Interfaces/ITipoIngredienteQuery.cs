using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface ITipoIngredienteQuery
    {
        TipoIngrediente GetById(int tipoIngredienteId);
        List<TipoIngrediente> GetAll();
    }
}
