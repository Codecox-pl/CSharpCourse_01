using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.Models.Domain
{
    public class Tienda
    {
        public int TiendaId {  get; set; }
        public string? Nombre { get; set;}

        public string? Ubicacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Usuario? Usuario { get; set; }
        public ICollection<Categoria> CategoriaLista { get; set; }
    }
}
