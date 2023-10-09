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

        public Ingrediente GetById(int ingredienteId)
        {
            var ingrediente = _context.Ingredientes.FirstOrDefault(e => e.Id == ingredienteId);
            return ingrediente;
        }

        public List<Ingrediente> GetAll()
        {
            var ingredientes = _context.Ingredientes.Include(e => e.TipoIngrediente).Include(e => e.TipoMedida).ToList();
            return ingredientes;
        }
    }
}
