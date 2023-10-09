using Aplication.Interfaces;
using Aplication.Models;
using Aplication.Response;
using Application.Exceptions;
using Domain.Entities;

namespace Aplication.UseCase
{
    public class IngredienteService : IIngredienteService
    {
        private readonly IIngredienteCommand _command;
        private readonly IIngredienteQuery _query;
        private readonly ITipoIngredienteQuery _queryTipoIngrediente;

        public IngredienteService(IIngredienteCommand command, IIngredienteQuery query, ITipoIngredienteQuery queryTipoIngrediente)
        {
            _command = command;
            _query = query;
            _queryTipoIngrediente = queryTipoIngrediente;
        }

        public async Task<IngredienteResponse> CreateIngrediente(IngredienteRequest request)
        {
            var ingre = new Ingrediente
            {
                TipoIngredienteID = request.TipoIngredienteID,
                TipoMedidaID = request.TipoMedidaID,
                Name = request.Nombre,
            };

            return MapearIngrediente(await _command.Insert(ingre));
        }

        public IngredienteResponse GetById(int id)
        {
            var ingre = _query.GetById(id);

            if (ingre == null) { throw new NotFoundException("No existe Ingrediente con ese Id."); }

            return MapearIngrediente(ingre);
        }

        public List<IngredienteResponse> GetByName(string name)
        {
            var listIngre = _query.GetAll()
            .Where(e => (name != null && e.Name.Contains(name)))
            .Select(e => MapearIngrediente(e));

            if (!listIngre.Any()) { throw new NotFoundException("No existen Ingredientes con ese nombre."); }

            return listIngre.ToList();
        }

        private IngredienteResponse MapearIngrediente(Ingrediente ingre)
        {
            return new IngredienteResponse
            {
                Id = ingre.Id,
                Name = ingre.Name,
                TipoIngrediente = new TipoIngredienteGetResponse
                {
                    Id = ingre.TipoIngrediente.Id,
                    Name = ingre.TipoIngrediente.Name,
                },
                TipoMedida = new TipoMedidaGetResponse
                {
                    Id = ingre.TipoMedida.Id,
                    Name = ingre.TipoMedida.Name
                }
            };
        }
    }
}
