using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Clases
{
    public class Libro
    {
        private string _nombre;

        public string Nombre 
        {
          get { return _nombre; }
          set { _nombre = value; }
        }
        private string _autor;

        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }
        private int _cantidadPaginas;

        //ejemplo de la vida real
        public string MiPropiedad { get; set; }

        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public string GetDescripcion() => $"{Nombre} escritor por {Autor}, paginas {_cantidadPaginas}";
    }
}
