

namespace _01_DiseñoObjetos
{
    public class Estudiante : IComparable
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public Estudiante(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is null) return 1;
            if (obj is Estudiante miEstudiante)
            {
                if (miEstudiante.Apellido == this.Apellido)
                {

                    return this.Nombre!.CompareTo(miEstudiante.Nombre);

                }
                return this.Apellido!.CompareTo(miEstudiante.Apellido);
            }
            throw new ArgumentException("No es un objeto de tipo estudiante", nameof(obj));
        }
    }
}