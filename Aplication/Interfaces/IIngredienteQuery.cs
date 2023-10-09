using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface IIngredienteQuery
    {
        Ingrediente GetById(int ingredienteId);
        List<Ingrediente> GetAll();
    }
}
