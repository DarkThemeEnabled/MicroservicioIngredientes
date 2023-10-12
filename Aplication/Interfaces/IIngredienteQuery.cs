using Domain.Entities;

namespace Application.Interfaces
{
    public interface IIngredienteQuery
    {
        Ingrediente GetById(int ingredienteId);
        List<Ingrediente> GetAll();
    }
}
