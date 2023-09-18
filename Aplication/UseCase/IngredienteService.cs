using Aplication.Interfaces;
using Aplication.Models;
using Aplication.Response;
using Domain.Entities;

namespace Aplication.UseCase
{
    public class IngredienteService : IIngredienteService
    {
        private readonly IIngredienteCommand _command;
        private readonly IIngredienteQuery _query;

        public IngredienteService(IIngredienteCommand command, IIngredienteQuery query)
        {
            _command = command;
            _query = query;
        }

        public async Task<IngredienteResponse> CreateIngrediente(IngredienteRequest request)
        {
            var ingre = new Ingrediente
            {
                TipoIngredienteID = request.TipoIngredienteID,
                TipoMedidaID = request.TipoMedidaID,
                Nombre = request.Nombre,
            };
            await _command.Insert(ingre);
            return new IngredienteResponse
            {
                TipoIngredienteID = ingre.TipoIngredienteID,
                TipoMedidaID = ingre.TipoMedidaID,
                Nombre = ingre.Nombre,
            };
        }

        public async Task<IngredienteResponse> DeleteIngrediente(int ingredientId)
        {
            var ingre = await _command.Remove(ingredientId);
            return new IngredienteResponse
            {
                TipoIngredienteID = ingre.TipoIngredienteID,
                TipoMedidaID = ingre.TipoMedidaID,
                Nombre = ingre.Nombre,
            };
        }

        public List<Ingrediente> GetAll()
        {
            return _query.GetListIngrediente();
        }

        public IngredienteResponse GetByID(int ingredienteId)
        {
            var ingre = _query.GetIngrediente(ingredienteId);
            return new IngredienteResponse
            {
                TipoIngredienteID = ingre.TipoIngredienteID,
                TipoMedidaID = ingre.TipoMedidaID,
                Nombre = ingre.Nombre,
            };
        }

        public async Task<IngredienteResponse> UpdateIngrediente(int ingredientId, IngredienteRequest request)
        {
            var ingre = _query.GetIngrediente(ingredientId);
            var ingreUpdate = new Ingrediente
            {
                TipoIngredienteID = request.TipoIngredienteID,
                TipoMedidaID = request.TipoMedidaID,
                Nombre = request.Nombre,
            };
            ingre = await _command.Update(ingre, ingreUpdate);
            return new IngredienteResponse
            {
                TipoIngredienteID = ingre.TipoIngredienteID,
                TipoMedidaID = ingre.TipoMedidaID,
                Nombre = ingre.Nombre,
            };
        }
    }
}
