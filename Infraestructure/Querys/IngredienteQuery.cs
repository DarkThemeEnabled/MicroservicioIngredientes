using Aplication.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Querys
{
    public class IngredienteQuery : IIngredienteQuery
    {
        public readonly IngredientesDBContext _context;

        public IngredienteQuery(IngredientesDBContext context)
        {
            _context = context;
        }

        public Ingrediente GetIngrediente(int ingredienteId)
        {
            var ingrediente = _context.Ingredientes.FirstOrDefault(e => e.IngredienteID == ingredienteId);
            return ingrediente;
        }

        public List<Ingrediente> GetListIngrediente()
        {
            var ingredientes = _context.Ingredientes.Include(e => e.TipoIngrediente).Include(e => e.TipoMedida).ToList();
            return ingredientes;
        }
    }
}
