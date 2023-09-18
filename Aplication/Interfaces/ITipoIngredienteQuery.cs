using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface ITipoIngredienteQuery
    {
        TipoIngrediente GetTipoIngrediente(int tipoIngredienteId);
        List<TipoIngrediente> GetListTipoIngrediente();
    }
}
