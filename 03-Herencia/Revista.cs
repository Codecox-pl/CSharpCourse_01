using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Herencia
{
    public class Revista : Publicacion
    {
        public string? Periodista {  get; set; }

        public Revista(string nombre, int cantidadPaginas, decimal precio, string periodista) : base(nombre,precio,cantidadPaginas) 
        { 
           Periodista = periodista;
        }

        public override string GetDescripcion() => $"{Nombre} escritor por {Periodista}, paginas {NumeroPaginas}";
    }
}
