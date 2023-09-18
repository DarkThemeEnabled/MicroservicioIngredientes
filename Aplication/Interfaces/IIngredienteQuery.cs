using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface IIngredienteQuery
    {
        Ingrediente GetIngrediente(int ingredienteId);
        List<Ingrediente> GetListIngrediente();
    }
}
