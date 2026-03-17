namespace AppStore.Models.Domain
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string NombrePro { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
