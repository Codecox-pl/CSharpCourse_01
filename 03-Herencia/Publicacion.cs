using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Herencia
{
    public class Publicacion
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int NumeroPaginas { get; set; }

        public Publicacion(string nombre, decimal precio, int numeropaginas) 
        {
            Nombre = nombre;
            Precio = precio;
            NumeroPaginas = numeropaginas;
        }

        public virtual string GetDescripcion() => $"{Nombre} precio {Precio}";
    }
}
