using Aplication.Response;

namespace Aplication.Interfaces
{
    public interface ITipoIngredienteService
    {
        TipoIngredienteResponse GetByTipoIngrediente(int id);
    }
}
