using Aplication.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Querys
{
    public class TipoIngredienteQuery : ITipoIngredienteQuery
    {
        public readonly IngredientesDBContext _context;

        public TipoIngredienteQuery(IngredientesDBContext context)
        {
            _context = context;
        }

        public TipoIngrediente GetById(int tipoIngredienteId)
        {
            var ti = _context.TiposIngrediente.FirstOrDefault(e => e.Id == tipoIngredienteId);
            return ti;
        }

        public List<TipoIngrediente> GetAll()
        {
            var tiposIngrediente = _context.TiposIngrediente.ToList();
            return tiposIngrediente;
        }
    }
}
