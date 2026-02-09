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
        private string _autor;
        private int _cantidadPaginas;

        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public string GetDescripcion()
        {
            return $"{_nombre} por {_autor}, cantidad {_cantidadPaginas}";
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public void SetNombre(string nombreLibro)
        {
            _nombre = nombreLibro;
        }
    }
}
