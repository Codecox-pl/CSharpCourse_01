using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Services_Interfaces
{
    public class Autor : IComparable<Autor>
    {
        public static int AutorCount = 0;
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public Autor(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            AutorCount++;
        }

        public override string ToString()
        {
            return $"{Nombre}  {Apellido}";
        }

        public int CompareTo(Autor? other)
        {
            return this.ToString().CompareTo(other.ToString());
        }

        //public int CompareTo(object? obj)
        //{
        //    if (obj is null) return 1;
        //    if(obj is Autor miAutor)
        //    {
        //        return this.ToString().CompareTo(miAutor.ToString());
        //    }
        //    throw new ArgumentException("No es un tipo de autor", nameof(obj));
        //}
    }


    public record NombreCompleto(string Nombre, string Apellido);
}
