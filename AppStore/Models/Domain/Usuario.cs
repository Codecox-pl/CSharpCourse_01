using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.Models.Domain
{
    public class Usuario
    {
        public int UsuarioId { get; set; } 

        public string? NombreCompl {  get; set; }

        public string? ApellidoCompl { get; set; }

        public string DNI {  get; set; } = string.Empty;

        public int TiendaId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Tienda Tienda { get; set; }
    }
}
