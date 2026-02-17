
namespace _01_DiseñoObjetos
{
    public class Estudiante : IComparable<Estudiante>
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

        public int CompareTo(Estudiante? miEstudiante)
        {

            if (miEstudiante?.Apellido == this.Apellido)
            {

                return this.Nombre!.CompareTo(miEstudiante?.Nombre);

            }
            return this.Apellido!.CompareTo(miEstudiante?.Apellido);

        }


    }
}
