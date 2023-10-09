using Aplication.Interfaces;
using Aplication.Response;
using Application.Exceptions;
using Domain.Entities;

namespace Aplication.UseCase
{
    public class TipoIngredienteService : ITipoIngredienteService
    {
        private readonly ITipoIngredienteQuery _query;

        public TipoIngredienteService(ITipoIngredienteQuery query)
        {
            _query = query;
        }

        public TipoIngredienteResponse GetByTipoIngrediente(int id)
        {
            var tipoIngre = _query.GetById(id);

            if (tipoIngre == null) { throw new NotFoundException("No existe un Tipo de Ingrediente que contengam ese Id."); }

            return MapearTipoIngrediente(tipoIngre);
        }

        public TipoIngredienteResponse MapearTipoIngrediente(TipoIngrediente tipoIngre)
        {
            return new TipoIngredienteResponse
            {
                Id = tipoIngre.Id,
                Name = tipoIngre.Name,
                List = tipoIngre.Ingredientes.Select(e => new IngredienteGetResponse
                {
                    Id = e.Id,
                    Name = e.Name,
                    TipoMedida = new TipoMedidaGetResponse
                    {
                        Id = e.TipoMedida.Id,
                        Name = e.TipoMedida.Name
                    }
                }).ToList()
            };
        }
    }
}
