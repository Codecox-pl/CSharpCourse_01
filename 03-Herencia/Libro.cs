using _03_Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Clases
{
    public class Libro : Publicacion 
    {
        private string _autor;

        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }

        //ejemplo de la vida real
        //public string MiPropiedad { get; set; }

        public Libro(string nombre, string autor, int cantidadPaginas, decimal precio) :base(nombre,precio,cantidadPaginas)
        {
            _autor = autor;
        }

        public override string GetDescripcion() => $"{Nombre} escritor por {Autor}, paginas {NumeroPaginas}";
    }
}
