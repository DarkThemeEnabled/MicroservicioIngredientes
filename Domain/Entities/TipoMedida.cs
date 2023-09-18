namespace Domain.Entities
{
    public class TipoMedida
    {
        public int TipoMedidaID { get; set; }
        public string Nombre { get; set; }
        public ICollection<Ingrediente> Ingredientes { get; set; } 
    }
}
