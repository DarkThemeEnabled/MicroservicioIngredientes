namespace Aplication.Response
{
    public class TipoIngredienteResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IngredienteGetResponse> List { get; set; }
    }

    public class IngredienteGetResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TipoMedidaGetResponse TipoMedida { get; set; }
    }
}
