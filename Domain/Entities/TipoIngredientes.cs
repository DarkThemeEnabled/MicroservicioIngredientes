namespace Domain.Entities
{
    public class TipoIngrediente
    {
        public int TipoIngredienteID { get; set; }
        public string Nombre { get; set; }
        public ICollection<Ingrediente> Ingredientes { get; set; } 
    }
}
