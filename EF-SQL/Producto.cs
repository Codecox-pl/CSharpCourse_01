using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SQL
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string NombrePro {  get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public ICollection<CategoriaProducto> Categorias { get; set; }
    }
}
