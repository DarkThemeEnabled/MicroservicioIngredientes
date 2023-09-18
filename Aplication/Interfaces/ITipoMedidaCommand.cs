using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface ITipoMedidaCommand
    {
        Task<TipoMedida> Insert(TipoMedida tipoMedida);
        Task<TipoMedida> Remove(int tipoMedidaId);
        Task<TipoMedida> Update(TipoMedida tipoMedida);
    }
}
