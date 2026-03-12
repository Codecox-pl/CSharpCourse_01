using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SQL
{
    public class CategoriaProducto
    {
        public int CategoriaId { get; set; }
        public int ProductoId { get; set; }

        public Categoria Categoria { get; set; }

        public Producto Producto { get; set; }
    }
}
