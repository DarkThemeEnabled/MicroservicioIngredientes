using Aplication.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class IngredienteCommand : IIngredienteCommand
    {
        public readonly IngredientesDBContext _context;

        public IngredienteCommand(IngredientesDBContext context)
        {
            _context = context;
        }

        public async Task<Ingrediente> Insert(Ingrediente ingrediente)
        {
            _context.Ingredientes.Add(ingrediente);
            await _context.SaveChangesAsync();
            return ingrediente;
        }

        public async Task<Ingrediente> Remove(int ingredienteId)
        {
            var ingreToDelete = await _context.Ingredientes.FirstOrDefaultAsync(e =>
                e.IngredienteID == ingredienteId);
            _context.Ingredientes.Remove(ingreToDelete);
            await _context.SaveChangesAsync();
            return ingreToDelete;
        }

        public async Task<Ingrediente> Update(Ingrediente ingrediente, Ingrediente ingredienteUpdate)
        {
            ingrediente.TipoIngredienteID = ingredienteUpdate.TipoIngredienteID;
            ingrediente.TipoMedidaID = ingredienteUpdate.TipoMedidaID;
            ingrediente.Nombre = ingredienteUpdate.Nombre;
            await _context.SaveChangesAsync();
            return ingrediente;
        }
    }
}
