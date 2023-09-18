using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface ITipoMedidaQuery
    {
        TipoMedida GetTipoMedida(int tipoMedidaId);
        List<TipoMedida> GetListTipoMedida();
    }
}
