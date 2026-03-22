using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.Models.Domain
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion {  get; set; }

        public int TiendaId { get; set; }

        public ICollection<Producto>? ProductoRelationList { get; set; }
        public ICollection<CategoriaProducto>? ProductoCategoriaRelationList { get; set; }
    }
}
